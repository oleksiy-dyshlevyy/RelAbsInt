using OOPLec2Example.CompositionAggregation;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLec2Example.CompositionAggregation
{
    public class Car
    {
        //class MyEngine
        //{ }
        //private class ElectricEngine1
        //{
        //    public ElectricEngine1()
        //    { }
        //}

        //MyEngine myEngine;

        AbstractEngine engine;// = new ElectricEngine();
       // ElectricEngine engine = new ElectricEngine();
        public Car()
        { /*engine = new ElectricEngine();*/ }
        public Car(AbstractEngine engine)
        {
            this.engine = engine;// new Engine();
        }

        //public void ReplaceEngine(AbstractEngine engine)
        //{
        //    this.engine = engine;
        //}

    }

   
}
