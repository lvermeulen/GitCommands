using System;
using GitCommand;
using McMaster.Extensions.CommandLineUtils;

namespace GitCommands.Subcommands
{
    public class CommitSubcommand : BaseSubcommand
    {
        public CommitSubcommand()
        {
            Name = "commit";
            Description = "git commit -m <message>";

            var userNameOption = new CommandOption("-u|--username <USERNAME>", CommandOptionType.SingleValue);
            Options.Add(userNameOption);

            var emailOption = new CommandOption("-e|--email <EMAIL>", CommandOptionType.SingleValue);
            Options.Add(emailOption);

            var commitMessageOption = new CommandOption("-m|--message <MESSAGE>", CommandOptionType.SingleValue);
            Options.Add(commitMessageOption);
            
            OnExecute(() =>
            {
                string userName = userNameOption.Value();
                string email = emailOption.Value();
                string commitMessage = commitMessageOption.Value();

                var command = new CommitCommand();
                command.Execute(PathValueOrDefault, userName, email, commitMessage);

                if (!Quiet)
                {
                    Console.WriteLine("Committed");
                }

                return 0;
            });
        }
    }
}
