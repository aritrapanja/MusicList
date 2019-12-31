using System;
using System.Collections.Generic;
using System.Linq;
namespace MusicPaylist
{
    internal class AddNewPlayListForUser : IChangeInstruction
    {
        public string Id { get; set; }
        public string PlaylistId { get; set; }
        public string UserId { get; set; }

        public List<string> SongIds { get; set; }

        public AddNewPlayListForUser(GenericInstruction gi)
        {
            this.Id = gi.Id;
            this.PlaylistId = gi.PlaylistId;
            this.UserId = gi.UserId;
            this.SongIds = gi.SongIds;
        }

        public void Change(MusicManager mc)
        {
            System.Console.WriteLine($"Start Executing change id {Id}..");

            if (PlaylistId == null || UserId == null || SongIds == null)
            {
                System.Console.WriteLine($"PlayListId and UserId must be populated");
            }
            else if (mc.playlists.Find(x => x.id == PlaylistId) != null)
            {
                System.Console.WriteLine($"PlayListId: {PlaylistId} is presnt. No action will be taken.");
            }
            else if (mc.users.Find(x => x.id == UserId) == null)
            {
                System.Console.WriteLine($"UserId: {UserId} cannot be found");
            }
            else
            {
                var pl = new Playlist();
                pl.id = PlaylistId;
                pl.user_id = UserId;
                pl.song_ids = new List<string>();
                foreach (var songId in SongIds)
                {
                    if(mc.songs.FindAll(x => x.id == songId)== null)
                        System.Console.WriteLine($"SongId: {songId} cannot be found. This not be part of play list");
                    else
                    {
                        pl.song_ids.Add(songId);
                    }
                }

                mc.playlists.Add(pl);
                System.Console.WriteLine($"Finished sucessfully Executing change id {Id}..");
            }
        }
    }
}