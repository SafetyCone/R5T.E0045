using System;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.L0011.X000;


namespace Roslyn.Library
{
    public static class SyntaxNodeHelper
    {
        public static SyntaxNode GetExampleSyntaxNode()
        {
            var testMethodDeclaration = SyntaxFactory.MethodDeclaration(
                TypeSyntaxHelper.GetVoid(),
                "Test");

            return testMethodDeclaration;
        }
    }
}
