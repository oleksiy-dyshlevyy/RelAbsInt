using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLec2Example.InheritanceDeep
{
    public class D3Squere: D2Square
    {
        public double Volume()
        {
            return side * side * side;
        }

        public D3Squere()
        {
            Console.WriteLine("D3Square");
        }
        public new void Show()
        {
            Console.WriteLine("Square: side = {0}, volume = {1}", side, Volume());
            base.Show();
            protectMethod();
            ShowColor();

        }
    }
}
