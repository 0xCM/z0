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
    using static As;
    

    partial class ginx
    {

        [MethodImpl(Inline)]
        public static unsafe Vector128<T> vselect<T>(N128 n, T* pX, T* pY, T* pZ)
            where T : unmanaged
        {                    
            vloadu(pX, out Vector128<T> vA);
            vloadu(pY, out Vector128<T> vB);
            vloadu(pZ, out Vector128<T> vC);
            return vselect(vA,vB,vC);
        }

        [MethodImpl(Inline)]
        public static unsafe void vselect<T>(N128 n, T* pX, T* pY, T* pZ, T* pDst)
            where T : unmanaged
                => vstore(vselect(n, pX, pY, pZ), pDst);

        [MethodImpl(Inline)]
        public static unsafe Vector256<T> vselect<T>(N256 n, T* pX, T* pY, T* pZ)
            where T : unmanaged
        {                    
            vloadu(pX, out Vector256<T> vA);
            vloadu(pY, out Vector256<T> vB);
            vloadu(pZ, out Vector256<T> vC);
            return vselect(vA,vB,vC);
        }

        [MethodImpl(Inline)]
        public static unsafe void vselect<T>(N256 n, T* pX, T* pY, T* pZ, T* pDst)
            where T : unmanaged
                => vstore(vselect(n, pX, pY, pZ), pDst);

    }

}