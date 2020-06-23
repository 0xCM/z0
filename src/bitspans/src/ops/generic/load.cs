//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;

    partial class BitSpans
    {
        /// <summary>
        /// Creates a bitspan from an arbitrary number of primal values
        /// </summary>
        /// <param name="packed">The packed data source</param>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static BitSpan load<T>(Span<T> packed)
            where T : unmanaged
                => load(packed.Bytes());

        /// <summary>
        /// Creates a bitspan from an arbitrary number of primal values
        /// </summary>
        /// <param name="packed">The packed data source</param>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static BitSpan load<T>(ReadOnlySpan<T> packed)
            where T : unmanaged
                => load(packed.Bytes());
    }
}