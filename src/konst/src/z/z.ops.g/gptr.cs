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
        public static unsafe T* gptr<T>(in T src)
            where T : unmanaged
                => memory.gptr(src);

        [MethodImpl(Inline)]
        public static unsafe T* gptr<T>(in T src, int offset)
            where T : unmanaged
                => memory.gptr(src,offset);

        [MethodImpl(Inline)]
        public unsafe static T* gptr<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => memory.gptr(src);

        [MethodImpl(Inline)]
        public static unsafe T* gptr<S,T>(in S src)
            where S : unmanaged
            where T : unmanaged
                => memory.gptr<S,T>(src);
    }
}