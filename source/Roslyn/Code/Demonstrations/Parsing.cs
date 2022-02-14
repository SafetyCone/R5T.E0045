using System;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;


namespace Roslyn.Demonstrations
{
    public static class Parsing
    {
        public static void SubMain()
        {
            Parsing.ParseVoidTypeName();
        }

        private static void ParseVoidTypeName()
        {
            var voidType = SyntaxFactory.ParseTypeName("void");


        }
    }
}
