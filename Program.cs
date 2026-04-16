//using OOPLec2Example.Implementation;
//using OOPLec2Example.Inheritance;
//using OOPLec2Example.CompositionAggregation;
using System;
//using System.Text.RegularExpressions;
//using OOPLec2Example.InheritanceDeep;
//using System.Collections;
//using System.Collections.Generic;

//using OOPLec2Example.Interfaces;

namespace OOPLec2Example
{
    class MyString
    {
        string str;
        public int Length()
        {
            return str.Length;
        }
    }
    class Text
    {
        MyString[] myString;

        Text()
        {
            myString = new MyString[5];
            myString[0] = new MyString();

        }

        int TextLength()
        {
            int l = 0;
            for (int i = 0; i < 5; i++)
                l += myString[i].Length();
            return l;
        }
       
    }

   
  
    class Program
    {
     
        static void Main(string[] args)
        {

           
            #region Lec - Interfaces



        //     UkrainianArtist person1 = new UkrainianArtist();
        //     FranchArtist person2 = new FranchArtist();
        //     person1.Magic();

        //     IArtist p;// = new UkrainianArtist();
            
        //     p = person1;
        //     p.SingSong();
        //     p = person2;
        //     p.SingSong();

        //     AB ab = new AB();
        //     ab.Method();
        //     ab.Method1();
          
        //     InterfaceA interfaceA = new AB();
        //     interfaceA.Method();
        //    // interfaceA.Method1();

        //     InterfaceB interfaceB = new AB();
        //     interfaceB.Method();

        //     char cc = ab.MethodA();
        //     cc = ab.MethodB();

            #endregion
           
           
        }
    }
}
