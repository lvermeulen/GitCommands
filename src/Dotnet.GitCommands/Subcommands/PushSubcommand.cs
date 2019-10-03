using System;
using System.Security;
using GitCommand;
using McMaster.Extensions.CommandLineUtils;

namespace GitCommands.Subcommands
{
    public class PushSubcommand : BaseSubcommand
    {
        public PushSubcommand()
        {
            Name = "push";
            Description = "git push";

            var userNameOption = new CommandOption("-u|--username <USERNAME>", CommandOptionType.SingleValue);
            Options.Add(userNameOption);

            var passwordOption = new CommandOption("-p|--password <PASSWORD>", CommandOptionType.SingleValue);
            Options.Add(passwordOption);

            var branchNameOption = new CommandOption("-b|--branch <BRANCHNAME>", CommandOptionType.SingleOrNoValue);
            Options.Add(branchNameOption);
            
            OnExecute(() =>
            {
                string userName = userNameOption.Value();
                string password = passwordOption.Value();
                var securePassword = new SecureString();
                foreach (char ch in password)
                {
                    securePassword.AppendChar(ch);
                }
                string branchName = ValueOrDefault(branchNameOption);

                var command = new PushCommand();
                command.Execute(PathValueOrDefault, userName, securePassword, branchName);

                if (!Quiet)
                {
                    Console.WriteLine("Pushed");
                }

                return 0;
            });
        }
    }
}
