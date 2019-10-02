using System;
using GitCommands;

namespace GitStatus
{
    public static class Program
    {
        public static int Main(string[] args)
        {
            string path = args.Length == 1 
                ? args[0] 
                : ".";
            
            var command = new StatusCommand();
            bool isDirty = command.Execute(path);
            
            Console.WriteLine(isDirty ? "Repository is dirty" : "Repository is clean");
            return isDirty
                ? 1
                : 0;
        }
    }
}
