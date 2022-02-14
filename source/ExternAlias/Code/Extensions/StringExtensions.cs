extern alias Library01;

using System;


namespace ExternAlias
{
    public static class StringExtensions
    {
        public static void StringExtension(this string _)
        {
            Library01::System.StringExtensions.StringExtension(_);
        }
    }
}
