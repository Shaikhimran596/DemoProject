using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace patientdemo
{
    public class patientcliview
    {
        patient p;
        patientmanager pl;
        public patientcliview()
        {
            pl = new patientmanager();
        }
        public int menuchoice()
        {
            Console.WriteLine("1. New patient");
            Console.WriteLine("2. Modify patient");
            Console.WriteLine("3. Remove patient");
            Console.WriteLine("4. find patient");
            Console.WriteLine("5. patient summary");
            Console.WriteLine("6. Exit");
            Console.WriteLine(" Please Enter Choice ");
            int ch = int.Parse(Console.ReadLine());
            return ch;
        }
        public void Addpatientview()
        {
            int id;
            string name, gender, mobile, disease;
            double weight, height;
            id = pl.Generateid();
            Console.WriteLine("New patient ID{0}", id);
            Console.Write("Please Enter patient Name\t:\t");
            name = Console.ReadLine();
            Console.Write("Please Enter patient Gender\t:\t");
            gender = Console.ReadLine();
            Console.WriteLine("Please Enter patient Mobile no\t:\t");
            mobile = Console.ReadLine();
            Console.WriteLine("Please Enter patient Weight\t:\t");
            double weight =double.Parse(Console.ReadLine());


            p = new patient
            {
                pid = id,
                pname = name,
                pgender = gender,
                pmobile = mobile,

            };
        }
    }
}
 
