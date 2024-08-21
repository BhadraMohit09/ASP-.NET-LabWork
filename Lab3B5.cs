using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_MAB
{
    internal class Lab3B5
    {
        public virtual void HospitalDetails() { }
    }
    class Apollo: Lab3B5 {
        public override void HospitalDetails()
        {
            Console.WriteLine("Apollo Hospitals...");
        }
    }

    class WorkHard : Lab3B5 {
        public override void HospitalDetails()
        {
            Console.WriteLine("WorkHard Hospitals...");
        }
    }

    class Gokul : Lab3B5
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Gokul Hospitals...");
        }
    }
}
