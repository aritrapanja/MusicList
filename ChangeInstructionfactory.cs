using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPaylist
{
    public static class ChangeInstructionfactory
    {
        public static IChangeInstruction Create(GenericInstruction gi)
        {
            if(gi.Type == ChangeInstructionType.AddSongToPlayList.ToString())
            {
                return new AddSongToPlayList(gi);
            }

            if (gi.Type == ChangeInstructionType.AddNewPlayListForUser.ToString())
            {
                return new AddNewPlayListForUser(gi);
            }

            if (gi.Type == ChangeInstructionType.RemoveExistingPlayList.ToString())
            {
                return new RemoveExistingPlayList(gi);
            }

            return null;
        }
    }
}
