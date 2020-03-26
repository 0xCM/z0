//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Textual;

    partial class XText
    {
        /// <summary>
        /// Returns true if a string is null or whitespace; otherwise, returns false
        /// </summary>
        /// <param name="s">The string to evaluate</param>
        [MethodImpl(Inline)]
        public static bool IsBlank(this string s)
            => text.empty(s);

        /// <summary>
        /// Returns true if a string has at least one character that is not considered whitespace
        /// </summary>
        /// <param name="s">The string to evaluate</param>
        [MethodImpl(Inline)]
        public static bool IsNotBlank(this string s)
            => text.nonempty(s);

        /// <summary>
        /// Returns the source string if it is not blank; otherwise, returns an alternate string
        /// </summary>
        /// <param name="src">The soruce string</param>
        /// <param name="alt">The alternate string</param>
        [MethodImpl(Inline)]
        public static string IfBlank(this string src, string alt)
            => text.empty(src) ? alt : src;

        /// <summary>
        /// Invokes an action if the source string is nonempty
        /// </summary>
        /// <param name="s">The string to evaluate</param>
        /// <param name="f">The action to conditionally invoke</param>
        [MethodImpl(Inline)]
        public static void OnSome(this string s, Action<string> f)
        {
            if(text.nonempty(s))
                f(s);
        }
    }
}