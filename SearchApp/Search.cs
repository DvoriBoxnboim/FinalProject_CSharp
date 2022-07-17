using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace SearchApp
{
    public delegate void MatchFound(string path, List<string> propertiesNames);
    class Search
    {
        public event MatchFound MatchFound;
        Type t;
        PropertyInfo[] properties;
        private List<string> suffixes;
        bool flag = false;
        public object objectForSearch { get; set; }
        public Search(object o, List<string> suffixes)
        {
            objectForSearch = o;
            this.suffixes = suffixes;
            t = objectForSearch.GetType();
            properties = t.GetProperties().Where(p => p.GetCustomAttribute<IgnoreSearchAttribute>() == null).ToArray();
        }

        public void SearchAFile(string path)
        {
            string[] arrFiles = Directory.GetFiles(path);
            foreach (string file in arrFiles)
            {
                StreamReader sr = new StreamReader(file);
                flag = suffixes.Any(s => file.EndsWith(s));

                List<string> propertiesFound = new List<string>();
                string fileContent = sr.ReadToEnd();
                if (flag)
                {
                    foreach (var property in properties)
                    {
                        if (fileContent.Contains(property.GetValue(objectForSearch).ToString()))
                        {
                            propertiesFound.Add(property.GetValue(objectForSearch).ToString());
                        }
                    }
                }
                if (propertiesFound.Count() > 0)
                {
                    MatchFound?.Invoke(file, propertiesFound);
                }

                sr.Close();
                flag = false;
            }
        }
        public void DeepSearch(string path)
        {
            SearchAFile(path);

            string[] directory = Directory.GetDirectories(path);
            foreach (var item in directory)
            {
                DeepSearch(item);
            }
        }
    }
}
