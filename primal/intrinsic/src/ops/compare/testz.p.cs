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
        public static unsafe bool vtestz<T>(N128 n, T* pX, T* pY)
            where T : unmanaged
        {                    
            vload(pX, out Vector128<T> vA);
            vload(pY, out Vector128<T> vB);
            return vtestz(vA,vB);
        }

        [MethodImpl(Inline)]
        public static unsafe bool vtestz<T>(N128 n, T* pX)
            where T : unmanaged
            => vtestz(n, pX,pX);


        [MethodImpl(Inline)]
        public static unsafe bool vtestz<T>(N256 n, T* pA, T* pB)
            where T : unmanaged
        {                    
            vload(pA, out Vector256<T> vA);
            vload(pB, out Vector256<T> vB);
            return vtestz(vA,vB);
        }

        [MethodImpl(Inline)]
        public static unsafe bool vtestz<T>(N256 n, T* pX)
            where T : unmanaged
            => vtestz(n, pX,pX);

    }
}