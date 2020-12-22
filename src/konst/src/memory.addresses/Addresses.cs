//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static memory;

    [ApiHost]
    public readonly partial struct Addresses
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static bool equals(RelativeAddress a, RelativeAddress b)
            => a.Offset == b.Offset && a.Grain == b.Grain;

        /// <summary>
        /// Computes the whole number of T-cells identified by a reference
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint count<T>(in MemorySegment src)
            => (uint)(src.DataSize/size<T>());

        /// <summary>
        /// Covers a memory reference with a readonly span
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> view<T>(in MemorySegment src)
            => cover(src.BaseAddress.Ref<T>(), count<T>(src));

    }
}