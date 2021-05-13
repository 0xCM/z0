//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct memory
    {
        /// <summary>
        /// Covers a token-identified buffer with a bytespan
        /// </summary>
        [MethodImpl(Inline), Op]
        public static unsafe Span<byte> edit(BufferToken src)
            => cover(src.Address.Pointer<byte>(), src.BufferSize);

        /// <summary>
        /// Covers a token-identified buffer with a span
        /// </summary>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Span<T> edit<T>(BufferToken src)
            where T : unmanaged
                => cover(src.Address.Pointer<byte>(), src.BufferSize).Recover<T>();
    }
}