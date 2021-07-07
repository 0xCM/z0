//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    unsafe partial struct Buffers
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

        [MethodImpl(Inline), Op]
        public static Span<byte> edit(in NativeBuffer src)
            => new Span<byte>(src.Handle.ToPointer(), (int)src.Size);

        [MethodImpl(Inline), Op]
        public static Span<T> edit<T>(in NativeBuffer<T> src)
            where T : unmanaged
                => new Span<T>(src.Handle.ToPointer(), (int)src.Count);
    }
}