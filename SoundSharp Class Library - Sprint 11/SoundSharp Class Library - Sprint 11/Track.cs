using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundSharp_Classlib
{
    public class Track
    {
        private int id;
        private string name;
        private string artist;
        private string albumSource;
        private category style;
        private Time length;
        public Time Length
        {
            get { return length; }
            set { length = value; }
        }
    }

    public enum category
    {
        Ambient,
        Blues,
        Country,
        Disco,
        Electro,
        Hardcore,
        HardRock,
        HeavyMetal,
        Hiphop,
        Jazz,
        Jumpstyle,
        Klassiek,
        Latin,
        Other,
        Pop,
        Punk,
        Reggae,
        Rock,
        Soul,
        Trance,
        Techno
    }

    public struct Time
    {
        private int seconds;

        public int Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }

        private int minutes;

        public int Minutes
        {
            get { return minutes; }
            set { minutes = value; }
        }

        private int hours;

        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }



        public Time(int _seconds)
        {
            this.seconds = _seconds;
            this.minutes = 0;
            this.hours = 0;
        }
        public Time(int _minutes, int _seconds) 
        {
            this.seconds = _seconds;
            this.minutes = _minutes;
            this.hours = 0;
        }
        public Time(int _hours, int _minutes, int _seconds) 
        {
            this.seconds = _seconds;
            this.minutes = _minutes;
            this.hours = _hours;
        }
    }
}
