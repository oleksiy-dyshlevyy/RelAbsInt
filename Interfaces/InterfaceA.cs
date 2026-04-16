using System;
using System.Collections.Generic;
using System.Text;

namespace RelAbsInt.Interfaces;

   public interface InterfaceA
    {
        char Method();
    }

    public interface InterfaceB
    {
        char Method();
    }

    public class AB : InterfaceA, InterfaceB
    {
        public int Method1()
        { return 1; }
        public char Method()
        {
            return 'A';
        }

        char InterfaceA.Method()
        {
            return 'A';
        }

        char InterfaceB.Method()
        {
            return 'B';
        }

        public char MethodA()
        {
            InterfaceA i = this;
            return i.Method();
        }
        public char MethodB()
        {
            InterfaceB i = this;
            return i.Method();
        }

    }

