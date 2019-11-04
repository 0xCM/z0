//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static As;
    using static zfunc;

    partial class ginx
    {

        [MethodImpl(Inline)]
        public static unsafe Vector128<T> vand<T>(N128 n, T* pX, T* pDst)
            where T : unmanaged
        {                    
            vload(pX, out Vector128<T> vA);
            vload(pDst, out Vector128<T> vB);
            return vand(vA,vB);
        }

        [MethodImpl(Inline)]
        public static unsafe void vand<T>(N128 n, T* pX, T* pY, T* pDst)
            where T : unmanaged
                => vstore(vand(n, pX,pY), pDst);

        [MethodImpl(Inline)]
        public static unsafe Vector256<T> vand<T>(N256 n, T* pX, T* pY)
            where T : unmanaged
        {                    
            vload(pX, out Vector256<T> vA);
            vload(pY, out Vector256<T> vB);
            return vand(vA,vB);
        }

        [MethodImpl(Inline)]
        public static unsafe void vand<T>(N256 n, T* pX, T* pY, T* pDst)
            where T : unmanaged
                => vstore(vand(n, pX,pY), pDst);

        [MethodImpl(Inline)]
        public static unsafe void next<T>(ref T* pX, ref T* pY, ref T* pDst, int offset)
            where T : unmanaged
        {
            pX += offset;
            pY += offset;
            pDst += offset;
        }

        [MethodImpl(Inline)]
        public static unsafe void vand<T>(N128 n, N2 n2, T* pX, T* pY, T* pDst)
            where T : unmanaged
        {
            var step = 128/Unsafe.SizeOf<T>();
            T* pXNext = pX, pYNext = pY, pDstNext = pDst;
            vstore(vand(n, pXNext, pYNext), pDstNext);
            next(ref pXNext, ref pYNext, ref pDstNext, step);
            vstore(vand(n, pXNext, pYNext), pDstNext);
        }
    }

}