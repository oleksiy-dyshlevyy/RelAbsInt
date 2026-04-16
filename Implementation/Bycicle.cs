using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLec2Example.Implementation
{
    public class Bicycle: IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }
}
