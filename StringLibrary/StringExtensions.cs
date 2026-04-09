using System;

namespace StringLibrary
{
    public static class StringExtensions
    {
        public static bool StartsWithUpper(this string? input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            char firstChar = input[0];

            return char.IsUpper(firstChar);
        }
    }
}