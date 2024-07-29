using CalculatorConsoleApp.Commands.Add;
using CalculatorConsoleApp.Commands.Divide;
using CalculatorConsoleApp.Commands.Multiply;
using CalculatorConsoleApp.Commands.Substract;
using Spectre.Console.Cli;

var app = new CommandApp();

app.Configure(config =>
{
    config.AddCommand<AddCommand>("add");
    config.AddCommand<DivideCommand>("divide");
    config.AddCommand<MultiplyCommand>("multiply");
    config.AddCommand<SubtractCommand>("subtract");
});

return app.Run(args);