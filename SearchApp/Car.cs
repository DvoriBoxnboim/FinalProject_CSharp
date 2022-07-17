using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchApp
{
    class Car
    {
        public string CarNumber { get; set; }
        public string Company { get; set; }
        public Car(string CarNumber, string Company)
        {
            this.CarNumber = CarNumber;
            this.Company = Company;
        }
    }
}

