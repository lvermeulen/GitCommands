using System;
using McMaster.Extensions.CommandLineUtils;

namespace GitCommands.Subcommands
{
    public abstract class BaseSubcommand : CommandLineApplication
    {
        protected BaseSubcommand()
        {
            var pathOption = new CommandOption("-p|--path <PATH>", CommandOptionType.SingleOrNoValue);
            Options.Add(pathOption);

            var quietOption = new CommandOption("-q|--quiet", CommandOptionType.NoValue);
            Options.Add(quietOption);
        }

        protected CommandOption FindOption(string optionName) => Options.Find(x => x.LongName.Equals(optionName, StringComparison.InvariantCultureIgnoreCase));

        protected static string ValueOrDefault(CommandOption option, string defaultValue = null) => option.HasValue()
            ? option.Value()
            : defaultValue;

        protected string PathValueOrDefault
        {
            get
            {
                var option = FindOption("path");
                return ValueOrDefault(option, ".");
            }
        }

        protected bool Quiet
        {
            get 
            {                
                var option = FindOption("quiet");
                return option.HasValue();
            }
        }
    }
}
