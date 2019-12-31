using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPaylist
{
    public class Playlist
    {
        public string id { get; set; }
        public string user_id { get; set; }
        public List<string> song_ids { get; set; }
    }
}
