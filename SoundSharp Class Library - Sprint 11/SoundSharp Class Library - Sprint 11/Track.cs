using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundSharp_Class_Library___Sprint_11
{
    public enum Category
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
        public int seconds { get; set; }
        public int minutes { get; set; }
        public int hours { get; set; }
    }



    public class Track
    {
        private int id;
        private string name;
        private string artist;
        private string albumSource;
        
    }


    Time a = new Time(100);
}
