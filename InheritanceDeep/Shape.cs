using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLec2Example.InheritanceDeep
{
    public enum Color { RED, BLUE, GREEN, WHITE, BLACK, YELLOW, GREY };

    public class Shape
    {
        private int privMember;
       protected void protectMethod() { }

        public Color pen;
        public Color brush;

        public Shape()
        {
            pen = Color.BLACK;
            brush = Color.BLACK;

        }
        public Shape(Color p, Color b)
        {
            pen = p;
            brush = b;
        }

        public void ShowColor()
        {
//            protectMethod();
            Console.WriteLine("Pen and Brush of shape are {0}, {1}", pen, brush);
        }
        public new void Show()
        {
            Console.WriteLine("Pen and Brush of shape are {0}, {1}", pen, brush);
        }
    }
}
