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
        public static unsafe bool vtestznc<T>(N128 n, in T rX, in T rY)
            where T : unmanaged
        {                    
            vload(rX, out Vector128<T> vA);
            vload(rY, out Vector128<T> vB);
            return vtestznc(vA,vB);
        }

        [MethodImpl(Inline)]
        public static unsafe bool vtestznc<T>(N256 n, in T rX, in T rY)
            where T : unmanaged
        {                    
            vload(rX, out Vector256<T> vA);
            vload(rY, out Vector256<T> vB);
            return vtestznc(vA,vB);
        }


    }

}