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
        /// Extracts a substring
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="start">The index of the first character</param>
        [MethodImpl(Inline), Op]
        public static string slice(string src, int start)
            => src.Substring(start);

        /// <summary>
        /// Extracts a substring
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="start">The index of the first character</param>
        /// <param name="length">The substring length</param>
        [MethodImpl(Inline), Op]
        public static string slice(string src, int start, int length)
            => src.Substring(start, length);
    }
}