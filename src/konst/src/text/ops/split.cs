//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class text
    {
        /// <summary>
        /// Splits the string, removing empty entries
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="sep">The delimiter</param>
        [MethodImpl(Inline), Op]
        public static string[] split(string src, char sep)
            => src.Split(sep, StringSplitOptions.RemoveEmptyEntries);

        /// <summary>
        /// Splits the string, removing empty entries
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="sep">The delimiter</param>
        [MethodImpl(Inline), Op]
        public static string[] split(string src, string sep)
            => src.Split(sep, StringSplitOptions.RemoveEmptyEntries);
    }
}