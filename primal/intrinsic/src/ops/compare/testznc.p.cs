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
        public static unsafe bool vtestznc<T>(N128 n, T* pX, T* pY)
            where T : unmanaged
        {                    
            vloadu(pX, out Vector128<T> vA);
            vloadu(pY, out Vector128<T> vB);
            return vtestznc(vA,vB);
        }

        [MethodImpl(Inline)]
        public static unsafe bool vtestznc<T>(N256 n, T* pA, T* pB)
            where T : unmanaged
        {                    
            vloadu(pA, out Vector256<T> vA);
            vloadu(pB, out Vector256<T> vB);
            return vtestznc(vA,vB);
        }


    }

}