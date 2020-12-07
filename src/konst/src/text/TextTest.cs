//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct TextTest
    {
        /// <summary>
        /// Tests whether the source string is either empty, null or consists only of whitespace
        /// </summary>
        /// <param name="src">The string to evaluate</param>
        [MethodImpl(Inline), Op]
        public static bool blank(string src)
            => string.IsNullOrWhiteSpace(src);

        /// <summary>
        /// Determines whether the source text is of the form "[{content}]"
        /// </summary>
        /// <param name="src">The source text</param>
        [Op]
        public static bool bracketed(string src)
            => fenced(src, Chars.LBracket, Chars.RBracket);

        /// <summary>
        /// Tests whether the source string is nonempty
        /// </summary>
        /// <param name="src">The string to evaluate</param>
        [MethodImpl(Inline), Op]
        public static bool nonempty(string src)
            => !string.IsNullOrEmpty(src);

        /// <summary>
        /// Tests whether the source string is either null or of zero length
        /// </summary>
        /// <param name="src">The string to test</param>
        [MethodImpl(Inline), Op]
        public static bool empty(string src)
            => string.IsNullOrEmpty(src);

        /// <summary>
        /// Determines whether the source text is of the form {left:char}{content:string}{right:char}, ignoring leading/trailing whitespace
        /// </summary>
        /// <param name="src">The text to analyze</param>
        /// <param name="left">The left boundary</param>
        /// <param name="right">The right boundary</param>
        [MethodImpl(Inline), Op]
        public static bool fenced(string src, char left, char right)
        {
            var result = false;
            if(text.nonempty(src))
            {
                var x = span(src.Trim());
                var length = x.Length;
                result = first(x) == left && skip(x,length - 1) == right;
            }

            return result;
        }
    }
}