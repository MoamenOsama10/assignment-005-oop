using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static assignment_005_oop.IShape1;

namespace assignment_005_oop
{
    internal interface IRectangle : IShape
    {
        double Length { get; set; }

        double Width { get; set; }
    }
}
