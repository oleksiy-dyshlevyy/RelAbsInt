using System;


namespace RelAbsInt.Interfaces;

    public interface IArtist
    {
        void SingSong();
        void Dance();
        void DeclaimPoem();
        int VoiceType
        {
            get;     
            set;    
        }

    }

    // public interface ISingable
    // {
    //     void SingSong(string songName);
    // }

    // public interface IDanceable
    // {
    //     void Dance();
    // }

    // public interface IPoetryDeclamation
    // {
    //     void DeclaimPoem();

    // }

    // public class Singer : ISingable, IDanceable
    // {
    //     public void SingSong(string songName)
    //     {
    //         Console.WriteLine(songName);
    //     }
    //     public void Dance()
    //     {
    //     }

    // }

    // public class Band: ISingable, IPoetryDeclamation
    // {
    //     public void SingSong(string songName)
    //     {
    //         Console.WriteLine(songName);
    //     }
    //     public void DeclaimPoem()
    //     {

    //     }
    // }

