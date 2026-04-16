using System;
using System.Collections.Generic;
using System.Text;

namespace RelAbsInt.Interfaces;

    public class UkrainianArtist: IArtist
    {
        public void SingSong()
        {
            Console.WriteLine("Ще не вмерла Україна");
        }
        public void Dance()
        {
            Console.WriteLine("Гопак");
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

        public void Magic()
        { }
    }

