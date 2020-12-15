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
        public static ref T seek<S,T>(in S src, uint count)
            => ref memory.seek<S,T>(src,count);

        [MethodImpl(Inline)]
        public static ref T seek<T>(in T src, byte count)
            => ref memory.seek(src,count);

        [MethodImpl(Inline)]
        public static ref T seek<T>(in T src, ushort count)
            => ref memory.seek(src,count);

        [MethodImpl(Inline)]
        public static ref T seek<T>(in T src, uint count)
            => ref memory.seek(src,count);

        [MethodImpl(Inline)]
        public static ref T seek<T>(in T src, ulong count)
            => ref memory.seek(src,count);

        [MethodImpl(Inline)]
        public static ref T seek<T>(in T src, long count)
            => ref memory.seek(src, count);

        [MethodImpl(Inline)]
        public static ref T seek<T>(in T src, int count)
            => ref memory.seek(src,count);

        [MethodImpl(Inline)]
        public static ref T seek<T>(Span<byte> src, uint count)
            => ref memory.seek<T>(src,count);

        [MethodImpl(Inline)]
        public static ref T seek<T>(Span<T> src, byte count)
            => ref memory.seek(src,count);

        [MethodImpl(Inline)]
        public static ref T seek<T>(Span<T> src, uint count)
            => ref memory.seek(src,count);

        [MethodImpl(Inline)]
        public static ref T seek<T>(Span<T> src, long count)
            => ref memory.seek(src,count);

        [MethodImpl(Inline)]
        public static ref T seek<T>(Span<T> src, ulong count)
            => ref memory.seek(src,count);

        [MethodImpl(Inline)]
        public static ref T seek<T>(Span<T> src, ushort count)
            => ref memory.seek(src,count);

        [MethodImpl(Inline)]
        public static ref T seek<T>(T[] src, byte count)
            => ref memory.seek(src,count);

        [MethodImpl(Inline)]
        public static ref T seek<T>(T[] src, ushort count)
            => ref memory.seek(src,count);

        [MethodImpl(Inline)]
        public static ref T seek<T>(T[] src, int count)
            => ref memory.seek(src, (ulong)count);

        [MethodImpl(Inline)]
        public static ref T seek<T>(T[] src, uint count)
            => ref memory.seek(src,count);

        [MethodImpl(Inline)]
        public static ref T seek<T>(T[] src, long count)
            => ref memory.seek(src,count);

        [MethodImpl(Inline)]
        public static ref T seek<T>(T[] src, ulong count)
            => ref memory.seek(src,count);
    }
}