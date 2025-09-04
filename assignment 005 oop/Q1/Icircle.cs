using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static assignment_005_oop.IShape1;

namespace assignment_005_oop
{
    internal class Icircle
    {
        public interface ICircle : IShape
        {
            double Radius { get; set; }
        }
    }
}
