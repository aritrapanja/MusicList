using System.IO;
using Newtonsoft.Json;

namespace MusicPaylist
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                System.Console.WriteLine("Running Unit Test Case:..");
                ExecuteChanges();
            }
            else if (args.Length == 3)
            {
                ExecuteChanges(args[0], args[1], args[2]);
            }
            else
            {
                System.Console.WriteLine("Please enter a commad like: application-name <input-file> <changes-file> <output-file>");
            }
        }

        private static void ExecuteChanges(string inputFile=@"testInput.json", string changesFile=@"TestChange.json", string outputFile=@"testout.json")
        {
            IInputProcessor ip = new JasonInputProcessor();
            var musicdata = ip.Process(inputFile);

            IChangeParser cp = new JsonChangeParser();
            var instructions = cp.ParseChangeInstructions(changesFile);

            foreach( var i in instructions)
            {
                i.Change(musicdata);
            }

            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter sw = new StreamWriter(outputFile))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, musicdata);
            }
        }
    }
}
