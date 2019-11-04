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
    
    using static zfunc;

    partial class ginx
    {
        [MethodImpl(Inline)]
        public static unsafe Vector128<T> vxor<T>(N128 n, T* pX, T* pY)
            where T : unmanaged
        {                    
            vload(pX, out Vector128<T> vA);
            vload(pY, out Vector128<T> vB);
            return vxor(vA,vB);
        }

        [MethodImpl(Inline)]
        public static unsafe void vxor<T>(N128 n, T* pX, T* pY, T* pDst)
            where T : unmanaged
                => vstore(vxor(n,pX,pY), pDst);

        [MethodImpl(Inline)]
        public static unsafe Vector256<T> vxor<T>(N256 n, T* pX, T* pY)
            where T : unmanaged
        {                    
            vload(pX, out Vector256<T> vA);
            vload(pY, out Vector256<T> vB);
            return vxor(vA,vB);
        }
        

        [MethodImpl(Inline)]
        public static unsafe void vxor<T>(N256 n, T* pX, T* pY, T* pDst)
            where T : unmanaged
                => vstore(vxor(n,pX,pY), pDst);

    }
}