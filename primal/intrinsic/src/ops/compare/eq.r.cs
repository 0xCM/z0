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
        public static unsafe Vector128<T> veq<T>(N128 n, in T rX, in T rY)
            where T : unmanaged
        {                    
            vload(rX, out Vector128<T> vA);
            vload(rY, out Vector128<T> vB);
            return veq(vA,vB);
        }

        [MethodImpl(Inline)]
        public static unsafe void veq<T>(N128 n, in T rX, in T rY, ref T rDst)
            where T : unmanaged
                => vstore(veq(n,in rX, in rY), ref rDst);


        [MethodImpl(Inline)]
        public static unsafe Vector256<T> veq<T>(N256 n, in T pA, in T pB)
            where T : unmanaged
        {                    
            vload(pA, out Vector256<T> vA);
            vload(pB, out Vector256<T> vB);
            return veq(vA,vB);
        }

        [MethodImpl(Inline)]
        public static unsafe void veq<T>(N256 n, in T rX, in T rY, ref T rDst)
            where T : unmanaged
                => vstore(veq(n,in rX, in rY), ref rDst);
    }

}