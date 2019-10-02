using System;
using GitCommands.Subcommands;
using McMaster.Extensions.CommandLineUtils;

namespace GitCommands
{
    public static class Program
    {
        public static int Main(string[] args)
        {
            int result;
            using (var app = new CommandLineApplication())
            {

                app.AddSubcommand(new StatusSubcommand());
                app.AddSubcommand(new AddAllSubcommand());
                app.AddSubcommand(new CommitSubcommand());
                app.AddSubcommand(new PushSubcommand());

                result = app.Execute(args);
            }

#if DEBUG
            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
#endif

            return result;
        }
    }
}
