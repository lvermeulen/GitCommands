using System;
using GitCommand;

namespace GitCommands.Subcommands
{
    public class AddAllSubcommand : BaseSubcommand
    {
        public AddAllSubcommand()
        {
            Name = "addall";
            Description = "git add --all";

            OnExecute(() =>
            {
                var command = new AddAllCommand();
                command.Execute(PathValueOrDefault);

                if (!Quiet)
                {
                    Console.WriteLine("All files added");
                }

                return 0;
            });
        }
    }
}
