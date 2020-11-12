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
        public static ref T seek<T>(Span<byte> src, uint count)
            => ref memory.seek<T>(src,count);

        [MethodImpl(Inline)]
        public static ref T seek<T>(Span<T> src, byte offset)
            => ref memory.seek(src,offset);

        [MethodImpl(Inline)]
        public static ref T seek<T>(Span<T> src, uint offset)
            => ref memory.seek(src,offset);

        [MethodImpl(Inline)]
        public static ref T seek<T>(Span<T> src, long offset)
            => ref memory.seek(src,offset);

        [MethodImpl(Inline)]
        public static ref T seek<T>(Span<T> src, ulong offset)
            => ref memory.seek(src,offset);

        [MethodImpl(Inline)]
        public static ref T seek<T>(Span<T> src, ushort offset)
            => ref memory.seek(src,offset);

        [MethodImpl(Inline)]
        public static ref T seek<T>(in T src, byte offset)
            => ref memory.seek(src,offset);

        [MethodImpl(Inline)]
        public static ref T seek<T>(in T src, ushort offset)
            => ref memory.seek(src,offset);

        [MethodImpl(Inline)]
        public static ref T seek<T>(in T src, uint offset)
            => ref memory.seek(src,offset);

        [MethodImpl(Inline)]
        public static ref T seek<T>(in T src, ulong offset)
            => ref memory.seek(src,offset);

        [MethodImpl(Inline)]
        public static ref T seek<T>(in T src, long offset)
            => ref memory.seek(src, offset);

        [MethodImpl(Inline)]
        public static ref T seek<T>(in T src, int offset)
            => ref memory.seek(src,offset);
    }
}