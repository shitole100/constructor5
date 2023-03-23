using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor5
{
    internal class doctor
    {
        public int id { get; set; }
        public string name { get; set; }
        public string degree { get; set; }

        public static int number { get; set; } 


        public doctor()

        {
            this.id = 10;
            this.name = "arun";
            this.degree = "bams";

        }

        public doctor(int id, string name, string degree)

        {
            this.id = id;
            this.name = name;
            this.degree = degree;

        }
        public doctor(doctor doctor)
        {

            this.id = doctor.id;
            this.name = doctor.name;
            this.degree =doctor. degree;


        }
        static doctor()
        {
            doctor.number = 4;
        }

        public void showdeta()
        {
            Console.WriteLine("id=" + this.id);
            Console.WriteLine("name=" + this.name);
            Console.WriteLine("degree= " + this.degree);


        }



    }
}

