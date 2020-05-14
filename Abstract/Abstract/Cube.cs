using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    class Cube : Shape
    {

        public double Length { get; set; }
        public double Width { get; set; }
        public double Heigth { get; set; }

        public Cube(double length)
        {
            Name = "Cube";
            this.Length = length;
           

        }
        public override double Volume()
        {
            var vol = Math.Pow(Length, 3);
            return vol;
            
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"The cube has a length of {Length} and volume of {Volume()}");
        }
    }
}
