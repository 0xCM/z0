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
        public static Vector128<T> vnand<T>(N128 n, in T rX, in T rY)
            where T : unmanaged
        {                    
            vload(in rX, out Vector128<T> vA);
            vload(in rY, out Vector128<T> vB);
            return vnand(vA,vB);
        }

        [MethodImpl(Inline)]
        public static unsafe void vnand<T>(N128 n, in T rX, in T rY, ref T rDst)
            where T : unmanaged
                => vstore(vnand(n, in rX, in rY), ref rDst);

        [MethodImpl(Inline)]
        public static Vector256<T> vnand<T>(N256 n, in T rX, in T rY)
            where T : unmanaged
        {                    
            vload(in rX, out Vector256<T> vA);
            vload(in rY, out Vector256<T> vB);
            return vnand(vA,vB);
        }

        [MethodImpl(Inline)]
        public static unsafe void vnand<T>(N256 n, in T rX, in T rY, ref T rDst)
            where T : unmanaged
                => vstore(vnand(n, in rX, in rY), ref rDst);
    }
}