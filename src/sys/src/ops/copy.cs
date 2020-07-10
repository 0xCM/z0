//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial struct sys
    {
        [MethodImpl(Options), Op]
        public static void copy(in byte src, ref byte dst, uint count)
            => xsys.copy(src,ref dst,count);

        [MethodImpl(Options), Op]
        public static unsafe void copy(byte* pSrc, byte* pDst, uint count)
            => xsys.copy(pSrc,pDst,count);

        [MethodImpl(Options), Op, Closures(Closure)]
        public static unsafe void copy<T>(T* pSrc, T* pDst, uint count)
            where T : unmanaged
                => xsys.copy(pSrc,pDst,count);

        [MethodImpl(Options), Op, Closures(Closure)]
        public static ref readonly Span<T> copy<T>(ReadOnlySpan<T> src, in Span<T> dst)
            => ref xsys.copy(src,dst);
    }
}