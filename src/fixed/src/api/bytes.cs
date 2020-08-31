//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Fixed
    {
        /// <summary>
        /// Presents a fixed value as a span of bytes
        /// </summary>
        /// <param name="src">The fixed source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Span<byte> bytes<F>(ref F src)
            where F : unmanaged, IFixedCell
                => new Span<byte>(Unsafe.AsPointer(ref src), Unsafe.SizeOf<F>());

        /// <summary>
        /// Presents a fixed source value as a reaodonly span of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="F">The fixed type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe ReadOnlySpan<byte> byteview<F>(in F src)
            where F : unmanaged, IFixedCell
                => new ReadOnlySpan<byte>(Unsafe.AsPointer(ref Unsafe.AsRef(in src)), Unsafe.SizeOf<F>());
    }
}