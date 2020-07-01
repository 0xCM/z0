//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static System.Runtime.CompilerServices.Unsafe;
    
    using O = OpacityKind;

    partial struct sys
    {
        [MethodImpl(Options), Opaque(O.CopyBlock)]
        public static void copy(in byte src, ref byte dst, uint count)
            => CopyBlock(ref dst, ref AsRef(src), count);

        [MethodImpl(Options), Opaque(O.CopyBlock)]
        public static unsafe void copy(byte* pSrc, byte* pDst, uint count)
            => CopyBlock(pDst, pSrc, count);

        [MethodImpl(Options), Opaque(O.CopyBlock)]
        public static unsafe void copy<T>(T* pSrc, T* pDst, uint count)
            where T : unmanaged
                => CopyBlock(pDst, pSrc, count* (uint)SizeOf<T>());
    }
}