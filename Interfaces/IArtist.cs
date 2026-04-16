using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLec2Example.Interfaces
{
    public interface IArtist
    {
        void SingSong();
        void Dance();
        void DeclaimPoem();
        int VoiceType
        {
            get;    // 0 - неопределен, 1 - бас, 
            set;    // 2 - тенор, 3 - сопрано
        }

    }

    public interface ISingable
    {
        void SingSong(string songName);
    }

    public interface IDanceable
    {
        void Dance();
    }

    public interface IPoetryDeclamation
    {
        void DeclaimPoem();

    }

    public class Singer : ISingable, IDanceable
    {
        public void SingSong(string songName)
        {
            Console.WriteLine(songName);
        }
        public void Dance()
        {
        }

    }

    public class Band: ISingable, IPoetryDeclamation
    {
        public void SingSong(string songName)
        {
            Console.WriteLine(songName);
        }
        public void DeclaimPoem()
        {

        }
    }
}
