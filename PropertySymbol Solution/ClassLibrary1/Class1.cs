using System;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace ClassLibrary1
{
    public class Class1
    {
        public void X()
        {
            var x = @"
public class User
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public DateTime? Date { get; set; }
}
";
            var comp = CSharpCompilation.Create(null, new[] { SyntaxFactory.ParseSyntaxTree(x) });
            var symbol = comp.GetTypeByMetadataName("User");
            var property = (IPropertySymbol)symbol.GetMembers("Date").First();
            Console.WriteLine(property.Type);
        }
    }
}
