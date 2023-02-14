using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Microsoft.CodeAnalysis.CSharp;

using R5T.L0011.X000;


namespace Roslyn.V001
{
    [TestClass]
    public class CompilationUnitSyntaxTests
    {
        [TestMethod]
        public void ParentOfNewCompilationUnitIsNull()
        {
            var newCompilationUnit = CompilationUnitSyntaxHelper.CreateNew();

            Instances.Assertion.IsNull(newCompilationUnit.Parent);
        }
    }
}
