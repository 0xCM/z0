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
        public static unsafe Vector128<T> vimply<T>(N128 n, T* pX, T* pDst)
            where T : unmanaged
        {                    
            vloadu(pX, out Vector128<T> vA);
            vloadu(pDst, out Vector128<T> vB);
            return vimply(vA,vB);
        }

        [MethodImpl(Inline)]
        public static unsafe void vimply<T>(N128 n, T* pX, T* pY, T* pDst)
            where T : unmanaged
                => vstore(vimply(n, pX,pY), pDst);

        [MethodImpl(Inline)]
        public static unsafe Vector256<T> vimply<T>(N256 n, T* pX, T* pY)
            where T : unmanaged
        {                    
            vloadu(pX, out Vector256<T> vA);
            vloadu(pY, out Vector256<T> vB);
            return vimply(vA,vB);
        }

        [MethodImpl(Inline)]
        public static unsafe void vimply<T>(N256 n, T* pX, T* pY, T* pDst)
            where T : unmanaged
                => vstore(vimply(n, pX,pY), pDst);
    }

}