using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTutorial15Dey
{
    public interface IShape
    {
        public double Area { get; }
        public double Perimeter { get; }
    }
    
    class Circle : IShape
    {
        public double Radius;
        public Circle(double r) {
            Radius = r;
        }

        public double Area {
            get { return Radius * Radius * Math.PI; }
        }

        public double Perimeter {
            get { return 2 * Radius * Math.PI; }
        }
    }

    class Rectangle : IShape
    {
        public double SideA;
        public double SideB;
        public Rectangle(double a, double b) {
            SideA = a;
            SideB = b;
        }

        public double Area {
            get { return SideA * SideB; }
        }

        public double Perimeter {
            get { return 2 * (SideA + SideB); }
        }
    }
   
}
