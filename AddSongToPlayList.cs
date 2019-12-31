using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPaylist
{
    public class AddSongToPlayList : IChangeInstruction
    {
        public AddSongToPlayList(GenericInstruction gi)
        {
            this.Id = gi.Id;
            this.PlaylistId = gi.PlaylistId;
            this.SongId = gi.SongId;
        }

        public string Id { get; set; }
        public string PlaylistId { get; set; }
        public string SongId { get; set; }

        public void Change(MusicManager mc)
        {
            System.Console.WriteLine($"Start Executing change id {Id}..");

            if (PlaylistId == null || SongId == null)
            {
                System.Console.WriteLine($"PlayListId and SongId must be populated");
            }
            else if( mc.playlists.Find(x => x.id == PlaylistId) == null)
            {
                System.Console.WriteLine($"PlayListId: {PlaylistId} cannot be found");
            }
            else if (mc.songs.Find(x => x.id == SongId) == null)
            {
                System.Console.WriteLine($"SongId: {SongId} cannot be found");
            }
            else if(mc.playlists.Find(x => x.id == PlaylistId).song_ids.Find(x => x == SongId) != null)
            {
                System.Console.WriteLine($"SongId: {SongId} is already in PlayListId: {PlaylistId}");
            }
            else
            {
                mc.playlists.Find(x => x.id == PlaylistId).song_ids.Add(SongId);
                System.Console.WriteLine($"Finished Sucessfulyy executing change id {Id}..");
            }
        }
    }
}
