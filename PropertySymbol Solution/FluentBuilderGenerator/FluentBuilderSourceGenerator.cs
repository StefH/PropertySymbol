using Microsoft.CodeAnalysis;

namespace FluentBuilderGenerator;

[Generator]
internal class FluentBuilderSourceGenerator : ISourceGenerator
{
    public void Initialize(GeneratorInitializationContext context)
    {
#if DEBUG
        if (!System.Diagnostics.Debugger.IsAttached)
        {
            System.Diagnostics.Debugger.Launch();
        }
#endif
    }

    public void Execute(GeneratorExecutionContext context)
    {
        var symbol = context.Compilation.GetTypeByMetadataName("ConsoleAppPropertySymbol.User");
        var property = (IPropertySymbol)symbol.GetMembers("Date").First();
        Console.WriteLine(property.Type);
    }
}