//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;    
    using System.Collections.Generic;

    using static Konst;

    partial class Spans
    {
        /// <summary>
        /// Loads a span from a memory reference
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="count">The number of source cells to read</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> view<T>(in T src, int count = 1)
            => MemoryMarshal.CreateReadOnlySpan(ref Unsafe.AsRef(in src), count);

        /// <summary>
        /// Loads a bytespan from a memory reference
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="count">The number of source cells to read</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ReadOnlySpan<byte> view8<T>(in T src, int count = 1)
            where T : unmanaged
                => MemoryMarshal.AsBytes(MemoryMarshal.CreateReadOnlySpan(ref Unsafe.AsRef(in src), count));
    }
}