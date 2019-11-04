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
        public static unsafe bool vtestc<T>(N128 n, in T pX)
            where T : unmanaged
        {                    
            vload(pX, out Vector128<T> vA);
            return vtestc(vA);
        }

        [MethodImpl(Inline)]
        public static unsafe bool vtestc<T>(N128 n, in T pX, in T pY)
            where T : unmanaged
        {                    
            vload(pX, out Vector128<T> vA);
            vload(pY, out Vector128<T> vB);
            return vtestc(vA,vB);
        }

        [MethodImpl(Inline)]
        public static unsafe bool vtestc<T>(N256 n, in T pX)
            where T : unmanaged
        {                    
            vload(pX, out Vector256<T> vA);
            return vtestc(vA);
        }

        [MethodImpl(Inline)]
        public static unsafe bool vtestc<T>(N256 n, in T pA, in T pB)
            where T : unmanaged
        {                    
            vload(pA, out Vector256<T> vA);
            vload(pB, out Vector256<T> vB);
            return vtestc(vA,vB);
        }
    }
}