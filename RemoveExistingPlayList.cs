namespace MusicPaylist
{
    internal class RemoveExistingPlayList : IChangeInstruction
    {
        public string Id { get; set; }
        public string PlaylistId { get; set; }

        public RemoveExistingPlayList(GenericInstruction gi)
        {
            this.Id = gi.Id;
            this.PlaylistId = gi.PlaylistId;
        }

        public void Change(MusicManager mc)
        {
            System.Console.WriteLine($"Start Executing change id {Id}.." );

            if(PlaylistId == null)
            {
                System.Console.WriteLine($"PlayListId must be populated");
            }
            else
            {
                mc.playlists.RemoveAll(x => x.id == PlaylistId);
                System.Console.WriteLine($"Finished Sucessfully executing change id {Id}..");
            }
        }
    }
}