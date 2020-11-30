//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class BitSpans
    {
        /// <summary>
        /// Creates a bitspan from an arbitrary number of primal values
        /// </summary>
        /// <param name="packed">The packed data source</param>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static BitSpan32 load32<T>(Span<T> packed)
            where T : unmanaged
                => load32(packed.Bytes());

        /// <summary>
        /// Creates a bitspan from an arbitrary number of primal values
        /// </summary>
        /// <param name="packed">The packed data source</param>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static BitSpan32 load32<T>(ReadOnlySpan<T> packed)
            where T : unmanaged
                => load32(packed.Bytes());
    }
}