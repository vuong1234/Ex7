using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Circle1
    {
        private double radius;
        public Circle1()
        {
            radius = 1.0;
        }
        public Circle1(double radius)
        {
            this.radius = radius;
        }
        public double Getradius()
        {
            return this.radius;
        }
        public void Setradius(double radius)
        {
            this.radius = radius;
        }
        public double GetArea()
        {
            return this.radius * this.radius * Math.PI;
        }

        public double GetCircumference()
        {
            return this.radius * 2 * Math.PI;
        }

        public override string ToString()
        {
            return String.Format("Circle [ Radius = {0}]", radius);


        }
    }
}
