using Spectre.Console;
using Spectre.Console.Cli;

namespace CalculatorConsoleApp.Commands.Divide;

public sealed class DivideCommand: Command<DivideSettings>
{
    public override int Execute(CommandContext context, DivideSettings settings)
    {
        if (settings.Second is 0)
        {
            settings.Second = AnsiConsole.Prompt(
                new TextPrompt<int>("Please enter again divider:")
                    .PromptStyle("green")
                    .ValidationErrorMessage("[red]That's not a valid divider[/]")
                    .Validate(age =>
                    {
                        return age switch
                        {
                            0 => ValidationResult.Error("[red]Cannot be zero[/]"),
                            _ => ValidationResult.Success(),
                        };
                    }));
        }
        
        AnsiConsole.WriteLine(settings.First / settings.Second!.Value);
        
        return 1;
    }
    
    public override ValidationResult Validate(CommandContext context, DivideSettings settings)
    {
        return settings.Second is null ? ValidationResult.Error("Second value cannot be null") : base.Validate(context, settings);
    }
}