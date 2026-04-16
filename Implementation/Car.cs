using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLec2Example.Implementation
{
    public interface IFuel
    { }
    public class Car: IMovable, IFuel
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }
}
