using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPaylist
{
    public class GenericInstruction
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string PlaylistId { get; set; }
        public string SongId { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }

        public List<string> SongIds { get; set; }
    }
}
