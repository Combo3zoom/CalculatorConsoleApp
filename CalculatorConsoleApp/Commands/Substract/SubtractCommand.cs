using Spectre.Console;
using Spectre.Console.Cli;

namespace CalculatorConsoleApp.Commands.Substract;

public sealed class SubtractCommand: Command<SubtractSettings>
{
    public override int Execute(CommandContext context, SubtractSettings settings)
    {
        AnsiConsole.WriteLine(settings.First - settings.Second!.Value);

        return 1;
    }
    public override ValidationResult Validate(CommandContext context, SubtractSettings settings)
    {
        return settings.Second is null ? ValidationResult.Error("Second value cannot be null") : base.Validate(context, settings);
    }
}