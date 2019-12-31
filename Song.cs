using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPaylist
{
    public class Song : IComparer<Song>
    {
        public string id { get; set; }
        public string artist { get; set; }
        public string title { get; set; }

        public int Compare(Song x, Song y)
        {
            return Int32.Parse(x.id) - Int32.Parse(y.id);
        }
    }
}
