Overview:

In a programming language of your choice, create a console application that applies a batch of changes to an input file in order to create an output file.

In the instructions below, we provide you with the input JSON file, which is called mixtape.json, and we tell you the types of changes your application should support. You will design the structure of the changes file and you will write the code that processes the specified changes and outputs a new file.

We'll expect to interact with your application like this:

$ application-name <input-file> <changes-file> <output-file>

For example:

$ killer-app mixtape.json changes.json output-file.json





1. I have chose json file (e.g. TestChange.json) to list the changes.
   I did not do extensive validation of files.
   Program.cs is the entry point of the program. 
   By default without any params passed it will run the unit test cases. 

   IInputProcess processes the input and store it in memory.
   IChangeparser process the change file and store as a list of instructions in memory.
   Then we run the instrucions to change the in memory data.
   At last we output them to out file.

   I have created intefaces, therefore adding a new input type ( say text), supporting new operation - (e.g. list all play list id) will be easier. I have used newton json ( a free libarary to parse jsonto an object).

   in order to scale this application:
   Newton Soft should support till 1GB of json file and will convert them to Object ( Given no momeory, CPU e.t.c. constains). 
   If we need to scale we must read the file in a thread and assign multiple threads to process on top of them. We need to change the data structure to store the songs/playlists and user. Simple list should not work, Need to use Dictionary, TreeMap depending on the instructons.
   If we want to go beyond that, we ust use map reduce kind of strategy. The file will be splitted and will be subitted to multiple data Node and a Name node will co-ordinate the data nodes. Each data node will have their store and processing powers. At the end we need to Reduce and accumulate all the data before we write back.

    How to run:
    I have tested in UBUNTU 18.04.3
    I used VSCode to compile and publish the exe. You need .net core sdk/ runtime lib to run this.exe/
    Download: .net Core from:
    https://docs.microsoft.com/en-us/dotnet/core/install/linux-package-manager-ubuntu-1804
    
    Go to the published directory and run:
    $ application-name <input-file> <changes-file> <output-file>

     Decompress ubuntu.18.04-x64.zip
     Change directory, run the NewMusicSolution.
     e.g aritra@aritra-ubuntu:~/Desktop/NewMusicSolution/bin/release/netcoreapp3.1/ubuntu.18.04-x64$ ./NewMusicSolution
     e.g. aritra@aritra-ubuntu:~/Desktop/NewMusicSolution$ ~/Desktop/NewMusicSolution/bin/release/netcoreapp3.1/ubuntu.18.04-x64/NewMusicSolution ./testInput.json ./TestChange.json  ../outfile.json