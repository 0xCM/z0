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

    partial struct Render
    {
        /// <summary>
        /// Formats a sequence of primal numeric calls as data-formatted hex
        /// </summary>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static string hexarray<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => Hex.formatter<T>().Format(src, HexFormatOptions.HexArray);
    }
}