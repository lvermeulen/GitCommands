using System;
using GitCommand;

namespace GitCommands.Subcommands
{
    public class StatusSubcommand : BaseSubcommand
    {
        public StatusSubcommand()
        {
            Name = "status";
            Description = "git status";

            OnExecute(() =>
            {
                var command = new StatusCommand();
                bool isDirty = command.Execute(PathValueOrDefault);

                if (!Quiet)
                {
                    Console.WriteLine(isDirty ? "Repository has changes" : "Repository has no changes");
                }

                return isDirty
                    ? 1
                    : 0;
            });
        }
    }
}
