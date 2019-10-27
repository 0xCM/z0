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
        public static unsafe Vector128<T> vxornot<T>(N128 n, T* pX, T* pY)
            where T : unmanaged
        {                    
            vloadu(pX, out Vector128<T> vA);
            vloadu(pY, out Vector128<T> vB);
            return vxor(vA,vnot(vB));
        }

        [MethodImpl(Inline)]
        public static unsafe void vxornot<T>(N128 n, T* pX, T* pY, T* pDst)
            where T : unmanaged
            => vstore(vxornot(n, pX,pY), pDst);

        [MethodImpl(Inline)]
        public static unsafe Vector256<T> vxornot<T>(N256 n, T* pX, T* pY)
            where T : unmanaged
        {                    
            vloadu(pX, out Vector256<T> vA);
            vloadu(pY, out Vector256<T> vB);
            return vxor(vA,vnot(vB));
        }

        [MethodImpl(Inline)]
        public static unsafe void vxornot<T>(N256 n, T* pX, T* pY, T* pDst)
            where T : unmanaged
            => vstore(vxornot(n, pX,pY), pDst);

    }

}