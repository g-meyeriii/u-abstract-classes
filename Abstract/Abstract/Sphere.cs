using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    class Sphere : Shape
    {
        public double Radius { get; set; }

        public Sphere (double radius)
        {
            Name = "Sphere";
            Radius = radius;
        }

        public override double Volume()

        {
            double vol = Math.PI * (Math.Pow(Radius, 3)) * 4 / 3;
            return vol;
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"The sphere has a radius of {Radius} and volume of {Volume()}");
        }

    }
}
