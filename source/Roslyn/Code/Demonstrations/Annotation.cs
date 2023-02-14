using System;
using System.Linq;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.L0011.X000;

using Roslyn.Library;


namespace Roslyn.Demonstrations
{
    public static class Annotation
    {
        public static void SubMain()
        {
            Annotation.WithAdditionalAnnotationsAddsAnnotations();
        }

        private static void WithAdditionalAnnotationsAddsAnnotations()
        {
            var exampleSyntaxNode = SyntaxNodeHelper.GetExampleSyntaxNode();

            var modified = exampleSyntaxNode;

            var annotation01 = SyntaxAnnotationHelper.New();

            modified = modified.WithAdditionalAnnotations(annotation01);

            var annotation02 = SyntaxAnnotationHelper.New();

            modified = modified.WithAdditionalAnnotations(annotation02);

            var annotations = modified.GetAnnotations().Now_OLD();

            var annotationCount = annotations.Length; // Length is 2, meaning that WithAdditionalAnnotations added the second annotation, instead of replacing annotations.
        }
    }
}
