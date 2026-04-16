using System;
using System.Collections.Generic;
using System.Text;

namespace RelAbsInt.Interfaces;

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class FranchArtist: Person, IArtist
    {
        public void SingSong()
        {
            Console.WriteLine("Marseliesa");
        }
    
    public void Dance()
    {
        Console.WriteLine("Minuet");
    }

        public void DeclaimPoem()
        { }
        public int VoiceType
    {
        set
        {
            if ((value >= 0) && (value <= 3))
                voiceType = value;
            else voiceType = 0;
        }
        get { return voiceType; }
    }
    private int voiceType;

}

