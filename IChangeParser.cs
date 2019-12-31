using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPaylist
{
    public interface IChangeParser
    {
        List<IChangeInstruction> ParseChangeInstructions(string filePath);
    }
}
