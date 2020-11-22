//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Cells
    {
        /// <summary>
        /// Presents a fixed value as a span of bytes
        /// </summary>
        /// <param name="src">The fixed source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Span<byte> bytes<F>(in F src)
            where F : unmanaged, IDataCell
                => new Span<byte>(z.pointer(ref z.edit(src)), (int)z.size<F>());

        /// <summary>
        /// Presents a fixed source value as a readonly span of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe ReadOnlySpan<byte> byteview<F>(in F src)
            where F : unmanaged, IDataCell
                => new ReadOnlySpan<byte>(Unsafe.AsPointer(ref Unsafe.AsRef(in src)), Unsafe.SizeOf<F>());
    }
}