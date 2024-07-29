using Spectre.Console;
using Spectre.Console.Cli;

namespace CalculatorConsoleApp.Commands.Multiply;

public sealed class MultiplyCommand: Command<MultiplySettings>
{
    public override int Execute(CommandContext context, MultiplySettings settings)
    {
        AnsiConsole.WriteLine(settings.First * settings.Second!.Value);

        return 1;
    }
    public override ValidationResult Validate(CommandContext context, MultiplySettings settings)
    {
        return settings.Second is null ? ValidationResult.Error("Second value cannot be null") : base.Validate(context, settings);
    }
}