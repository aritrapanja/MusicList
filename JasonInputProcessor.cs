using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPaylist
{
    public class JasonInputProcessor : IInputProcessor
    {
        public MusicManager Process(string filename)
        {
            string readJson = File.ReadAllText(filename);

            MusicManager mm = JsonConvert.DeserializeObject<MusicManager>(readJson);

            return mm;
        }
    }
}
