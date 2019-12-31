using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPaylist
{
    public class JsonChangeParser : IChangeParser
    {
        public List<IChangeInstruction> ParseChangeInstructions(string filePath)
        {
            List<IChangeInstruction> changeInstructions = new List<IChangeInstruction>();
            string readJson = File.ReadAllText(filePath);
            GenericInstructions changes = JsonConvert.DeserializeObject<GenericInstructions>(readJson);
            foreach (var change in changes.instructions)
            {
                changeInstructions.Add(ChangeInstructionfactory.Create(change));
            }
            return changeInstructions;
        }
    }
}
