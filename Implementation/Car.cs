using System;
using System.Collections.Generic;
using System.Text;

namespace RelAbsInt.Implementation;

    public interface IFuel
    { }
    public class Car: IMovable, IFuel
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

