using Spectre.Console.Cli;

namespace CalculatorConsoleApp.Common.Bases;

public class CalculatorSettingsBase : CommandSettings
{
    [CommandArgument(0, "<First>")]
    public decimal First { get; set; }
    [CommandArgument(1, "[Second]")]
    public decimal? Second { get; set; }
}