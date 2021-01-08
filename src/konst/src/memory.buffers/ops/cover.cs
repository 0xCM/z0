//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Buffers
    {
        /// <summary>
        /// Covers a token-identified buffer with a bytespan
        /// </summary>
        [MethodImpl(Inline), Op]
        public static unsafe Span<byte> cover(BufferToken src)
            => memory.cover(src.Address.Pointer<byte>(), src.BufferSize);

        /// <summary>
        /// Covers a token-identified buffer with a span
        /// </summary>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Span<T> cover<T>(BufferToken src)
            where T : unmanaged
                => memory.cover(src.Address.Pointer<byte>(), src.BufferSize).Cast<T>();
    }
}