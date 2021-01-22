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
        [MethodImpl(Inline), Op]
        public static unsafe MemoryAddress address(in byte src)
            => memory.p8u(src);

        [MethodImpl(Inline), Op]
        public static unsafe MemoryAddress address(in char src)
            => memory.p16c(src);

        [MethodImpl(Inline)]
        public unsafe static MemoryAddress address(void* p)
            => memory.address(p);

        [MethodImpl(Inline)]
        public static unsafe MemoryAddress address<P>(P* pSrc)
            where P : unmanaged
                => memory.address(pSrc);

        [MethodImpl(Inline)]
        public static MemoryAddress address<T>(Span<T> src)
            => memory.address(src);

        [MethodImpl(Inline)]
        public static unsafe MemoryAddress address<T>(ReadOnlySpan<T> src)
            => memory.address(src);

        [MethodImpl(Inline)]
        public static unsafe MemoryAddress address(Type src)
            => memory.address(src);

        [MethodImpl(Inline)]
        public static MemoryAddress address(ulong src)
            => memory.address(src);

        [MethodImpl(Inline)]
        public static unsafe MemoryAddress address(string src)
            => memory.address(src);

        [MethodImpl(Inline)]
        public static unsafe MemoryAddress address<T>(in T src)
            => memory.address(src);

        [MethodImpl(Inline), Op]
        public static MemoryAddress address(IntPtr src)
            => memory.address(src);

        [MethodImpl(Inline)]
        public static unsafe MemoryAddress address<T>(T[] src)
            => memory.address(src);

        [MethodImpl(Inline)]
        public static unsafe MemoryAddress address<T>(T[] src, int index)
            =>  memory.address(src,index);
    }
}