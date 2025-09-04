using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_005_oop
{
    internal class Circle
    {
        public double Radius { get; set; }

        public double Area
        {
            get { return Math.PI * Radius * Radius; }
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle - Radius : {Radius}, Area {Area}");
        }
    }
}
