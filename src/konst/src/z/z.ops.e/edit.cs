//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static ref T edit<T>(in T src)
            => ref memory.edit(src);

        [MethodImpl(Inline)]
        public static ref byte edit8u<T>(in T src)
            => ref memory.edit8u(src);

        [MethodImpl(Inline)]
        public static ref ushort edit16u<T>(in T src)
            => ref memory.edit16u(src);

        [MethodImpl(Inline)]
        public static ref uint edit32u<T>(in T src)
            => ref memory.edit32u(src);

        [MethodImpl(Inline)]
        public static ref ulong edit64u<T>(in T src)
            => ref memory.edit64u(src);

        [MethodImpl(Inline), Op]
        public static unsafe ref char edit16c(string src)
            => ref memory.edit16c(src);

        [MethodImpl(Inline)]
        public static Span<T> edit<T>(ReadOnlySpan<T> src)
            => memory.edit(src);

        [MethodImpl(Inline)]
        public static ref T edit<S,T>(in S src)
            => ref memory.edit<S,T>(src);

        [MethodImpl(Inline)]
        public static ref T edit<S,T>(in S src, ref T dst)
            => ref memory.edit(src, ref dst);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> edit(MemoryAddress src, ByteSize size)
            => memory.edit(src, size);
    }
}