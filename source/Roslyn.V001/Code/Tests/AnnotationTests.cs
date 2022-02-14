using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.L0011.X000;

using Instances = Roslyn.V001.Instances;


namespace Roslyn.V001
{
    [TestClass]
    public class AnnotationTests
    {
        [TestMethod]
        public void GetAnnotationsAnnotationKindCannotBeNull()
        {
            var testMethodDeclaration = SyntaxFactory.MethodDeclaration(
                TypeSyntaxHelper.GetVoid(),
                "Test");

            var modified = testMethodDeclaration;

            /// No annotation kind string is provided, and as shown by <see cref="DefaultAnnotationKindIsNull"/>, the kind is null.
            var annotation01 = new SyntaxAnnotation();

            modified = modified.WithAdditionalAnnotations(annotation01);

            string nullAnnotationKind = null;

            // However, you cannot get annotations with a null kind.
            Instances.Assertion.ThrowsException<ArgumentNullException>(
                () => modified.GetAnnotations(nullAnnotationKind),
                "Value cannot be null. (Parameter 'annotationKind')");
        }

        [TestMethod]
        public void DefaultAnnotationKindIsNull()
        {
            var annotation01 = new SyntaxAnnotation();

            Instances.Assertion.IsNull(annotation01.Kind);
        }
    }
}
