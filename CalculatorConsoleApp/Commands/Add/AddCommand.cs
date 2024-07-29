using Spectre.Console;
using Spectre.Console.Cli;

namespace CalculatorConsoleApp.Commands.Add;

public sealed class AddCommand : Command<AddSettings>
{
    public override int Execute(CommandContext context, AddSettings settings)
    {
        AnsiConsole.WriteLine(settings.First + settings.Second!.Value);
        
        return 1;
    }

    public override ValidationResult Validate(CommandContext context, AddSettings settings)
    {
        return settings.Second is null ? ValidationResult.Error("Second value cannot be null") : base.Validate(context, settings);
    }
}