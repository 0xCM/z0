//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Buffers
    {
        /// <summary>
        /// Covers a token-identified buffer with a bytespan
        /// </summary>
        [MethodImpl(Inline), Op]
        public static unsafe Span<byte> cover(BufferToken src)
            => As.cover(src.Address.Pointer<byte>(), (int)src.BufferSize);

        /// <summary>
        /// Covers a token-identified buffer with a span
        /// </summary>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe Span<T> cover<T>(BufferToken src)
            where T : unmanaged
                => As.cover(src.Address.Pointer<byte>(), (int)src.BufferSize).Cast<T>();       
    }
}