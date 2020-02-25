//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Root;

    public static partial class TextExtensions
    {
        /// <summary>
        /// Applies a function to a value
        /// </summary>
        /// <param name="x">The source value</param>
        /// <param name="f">The function to apply</param>
        /// <typeparam name="X">The source value type</typeparam>
        /// <typeparam name="Y">The output value type</typeparam>
        [MethodImpl(Inline)]   
        static Y apply<X,Y>(X x,Func<X,Y> f)
            => f(x);

        /// <summary>
        /// Tests whether the source string is nonempty
        /// </summary>
        /// <param name="src">The string to evaluate</param>
        [MethodImpl(Inline)]
        static bool nonempty(string src)
            => !String.IsNullOrWhiteSpace(src);

        /// <summary>
        /// Tests whether the source string is empty
        /// </summary>
        /// <param name="src">The string to evaluate</param>
        [MethodImpl(Inline)]
        static bool empty(string src)
            => String.IsNullOrWhiteSpace(src);

        /// <summary>
        /// Searches for the last index of a specified character in a string
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="c">The character to match</param>
        public static Option<int> LastIndexOf(this string s, char c)
        {
            var idx = s.LastIndexOf(c);
            return idx != -1 ? some(idx) : none<int>();
        }

        /// <summary>
        /// Searches a string for the first occurrence of a specified character
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="c">The marking character</param>
        public static Option<int> FirstIndexOf(this string s, char c)
        {
            var idx = s.IndexOf(c);
            return idx != -1 ? some(idx) : none<int>();
        }

        /// <summary>
        /// Removes whitespace characters from a string
        /// </summary>
        /// <param name="src">The source string</param>
        public static string RemoveWhitespace(this string src)
            => src.RemoveAny(items(AsciSym.Space, AsciEscape.LineFeed, AsciEscape.NewLine, AsciEscape.Tab));

        public static string Bracket(this string src)
            => $"[{src}]";
    }
}