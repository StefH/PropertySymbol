// This source code is based on https://justsimplycode.com/2020/12/06/auto-generate-builders-using-source-generator-in-net-5

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