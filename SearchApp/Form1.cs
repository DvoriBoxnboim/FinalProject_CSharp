using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;



namespace SearchApp
{
    public partial class Form1 : Form
    {
        object o;
        List<string> suffixesChooses = new List<string>();
        string path;
        string type;
        Thread t;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitialData()
        {
            switch (type)
            {
                case "Person":
                    o = new Person(tb_value1.Text, tb_value2.Text);
                    break;
                case "Student":
                    o = new Student(tb_value1.Text, tb_value2.Text);
                    break;
                case "Car":
                    o = new Car(tb_value1.Text, tb_value1.Text);
                    break;
            }
            suffixesChooses = tb_suffix.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();
        }

        private void lstbx_result_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_flat_Click(object sender, EventArgs e)
        {
            InitialData();
            Search s = new Search(o, suffixesChooses);
            s.MatchFound += printFoundProps;
            t = new Thread(() => s.SearchAFile(path));
            t.IsBackground = true;
            t.Start();
        }
        public void printFoundProps(string fileName, List<string> propsFound)
        {
            lstbx_result.Invoke(new MethodInvoker(() =>
            {
                lstbx_result.Items.Add("File Name: " + fileName);
                foreach (var p in propsFound)
                {
                    lstbx_result.Items.Add("prop: " + p);
                }
            }
            ));
        }
        private void btn_open_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            path = folderBrowserDialog1.SelectedPath;
        }

        private void r_person_CheckedChanged(object sender, EventArgs e)
        {
            type ="Person";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void r_car_CheckedChanged(object sender, EventArgs e)
        {
            type = "Car";
        }

        private void r_student_CheckedChanged(object sender, EventArgs e)
        {
            type = "Student";
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            t.Abort();
        }

        private void btn_deep_Click(object sender, EventArgs e)
        {
            InitialData();
            Search s = new Search(o, suffixesChooses);
            s.MatchFound += printFoundProps;
            t = new Thread(() => s.DeepSearch(path));
            t.IsBackground = true;
            t.Start();
        }
    }
}
