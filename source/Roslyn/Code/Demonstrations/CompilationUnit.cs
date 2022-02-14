using System;

using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.L0011.X000;


namespace Roslyn.Demonstrations
{
    public static class CompilationUnit
    {
        public static void SubMain()
        {
            CompilationUnit.LoadedCompilationUnitParentIs();
            //CompilationUnit.NewCompilationUnitParentIsNull();
        }

        private static void LoadedCompilationUnitParentIs()
        {
            var codeFilePath = @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.E0045\source\Roslyn\Code\Demonstrations\CompilationUnit.cs";

            var compilationUnit = CompilationUnitSyntaxHelper.LoadFileSynchronous(codeFilePath);

            var parentOfCompilationUnit = compilationUnit.Parent;
        }

        private static void NewCompilationUnitParentIsNull()
        {
            var compilationUnit = CompilationUnitSyntaxHelper.New();

            var parentOfCompilationUnit = compilationUnit.Parent;

            var isNull = parentOfCompilationUnit == null;

            Console.WriteLine($"Parent of new compilation unit it null: {isNull}");
        }
    }
}
