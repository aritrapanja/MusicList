namespace MusicPaylist
{
    /*
     * The types of changes your application needs to support are:
        Add an existing song to an existing playlist.
        Add a new playlist for an existing user; the playlist should contain at least one existing song.
        Remove an existing playlist.
     * */
    public enum ChangeInstructionType

    {

        AddSongToPlayList,

        AddNewPlayListForUser,

        RemoveExistingPlayList

    }
    public interface IChangeInstruction
    {
        void Change(MusicManager mc);
    }
}