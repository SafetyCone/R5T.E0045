extern alias Library01;
//extern alias Library02; // Note, must add dependency of dependency directly to the project as an duplicate dependency. See the setup for ExternAlias.Library01.

using System;



namespace ExternAlias
{
    public static class ExternAlias
    {
        public static void SubMain()
        {
            ExternAlias.TryLocal();
            //ExternAlias.TryExternAlias();
            //ExternAlias.DemonstrateAmbiguousCallAndDuplicateType();
        }

#pragma warning disable IDE0051 // Remove unused private members

        /// <summary>
        /// Another System.StringExtensions.StringExtension() method has been defined in this project, and it resolves the name ambiguity.
        /// This method demonstrates that the project's own (non-dependency) extension method base will be used.
        /// Awesome! This means that resolving extension methods can be done 
        /// </summary>
        private static void TryLocal()
        {
            var @string = "string";

            @string.StringExtension();
        }

        /// <summary>
        /// Note: for "extern alias" to work with dependencies of dependencies, the project must include a duplicate reference to the dependency of the dependency.
        /// Only then is there a location in the csproj XML to specify the alias.
        /// </summary>
        private static void TryExternAlias()
        {
            var @string = "string";

            Library01::System.StringExtensions.StringExtension(@string);
            //Library02::System.StringExtensions.StringExtension(@string);
        }

        /// <summary>
        /// Note meant to be run, but demonstrates the problem the C# "extern alias" feature solves.
        /// </summary>
        private static void DemonstrateAmbiguousCallAndDuplicateType()
        {
            // Error CS0121:
            // The call is ambiguous between the following methods or properties: 'System.StringExtensions.StringExtension(string)' and 'System.StringExtensions.StringExtension(string)'
            //@string.StringExtension();

            // Error CS0433:
            // The type 'StringExtensions' exists in both 'ExternAlias.Library01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null' and 'ExternAlias.Library02, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'
            //System.StringExtensions.StringExtension()
        }

#pragma warning restore IDE0051 // Remove unused private members
    }
}
