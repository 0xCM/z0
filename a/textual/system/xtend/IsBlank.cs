//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class XTend
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
    }
}