//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {

        [MethodImpl(Inline)]
        public static T read<T>(ReadOnlySpan<byte> src)
            where T : struct
                => memory.read<T>(src);

        [MethodImpl(Inline)]
        public static ref readonly T read2<T>(ReadOnlySpan<byte> src)
            => ref memory.read2<T>(src);

        [MethodImpl(Inline)]
        public static ref T read2<T>(Span<byte> src)
            => ref memory.read2<T>(src);

        [MethodImpl(Inline)]
        public unsafe static ref T read<T>(T* pSrc, int offset, ref T dst)
            where T : unmanaged
                => ref memory.read(pSrc, offset, ref dst);

        [MethodImpl(Inline)]
        public static unsafe void read<T>(T* pSrc, int offset, ref T dst, int count)
            where T : unmanaged
                => memory.read(pSrc, offset, ref dst, count);

        [MethodImpl(Inline)]
        public static ref readonly T read<S,T>(in S src)
            => ref memory.read<S,T>(src);

        [MethodImpl(Inline)]
        public static ref readonly T read<S,T>(in S src, int offset)
            => ref memory.read<S,T>(src, offset);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in byte src)
            => ref memory.read<T>(src);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in sbyte src)
            => ref memory.read<T>(src);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in short src)
            => ref memory.read<T>(src);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in ushort src)
            => ref memory.read<T>(src);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in int src)
            => ref memory.read<T>(src);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in uint src)
            => ref memory.read<T>(src);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in long src)
            => ref memory.read<T>(src);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in ulong src)
            => ref memory.read<T>(src);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in float src)
            => ref memory.read<T>(src);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in double src)
            => ref memory.read<T>(src);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in bool src)
            => ref memory.read<T>(src);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in char src)
            => ref memory.read<T>(src);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in decimal src)
            => ref memory.read<T>(src);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in byte src, int offset)
            => ref memory.read<T>(src, offset);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in sbyte src, int offset)
            => ref memory.read<T>(src, offset);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in short src, int offset)
            => ref memory.read<T>(src, offset);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in ushort src, int offset)
            => ref memory.read<T>(src, offset);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in int src, int offset)
            => ref memory.read<T>(src, offset);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in uint src, int offset)
            => ref memory.read<T>(src, offset);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in long src, int offset)
            => ref memory.read<T>(src, offset);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in ulong src, int offset)
            => ref memory.read<T>(src, offset);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in float src, int offset)
            => ref memory.read<T>(src, offset);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in double src, int offset)
            => ref memory.read<T>(src, offset);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in bool src, int offset)
            => ref memory.read<T>(src, offset);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in char src, int offset)
            => ref memory.read<T>(src, offset);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in decimal src, int offset)
            => ref memory.read<T>(src, offset);
    }
}