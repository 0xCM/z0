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
        public static Vector128<T> vxornot<T>(N128 n, in T rX, in T rY)
            where T : unmanaged
        {                    
            vload(in rX, out Vector128<T> vA);
            vload(in rY, out Vector128<T> vB);
            return vxornot(vA,vB);
        }

        [MethodImpl(Inline)]
        public static unsafe void vxornot<T>(N128 n, in T rX, in T rY, ref T rDst)
            where T : unmanaged
                => vstore(vxornot(n, in rX, in rY), ref rDst);

        [MethodImpl(Inline)]
        public static Vector256<T> vxornot<T>(N256 n, in T rX, in T rY)
            where T : unmanaged
        {                    
            vload(in rX, out Vector256<T> vA);
            vload(in rY, out Vector256<T> vB);
            return vxornot(vA,vB);
        }

        [MethodImpl(Inline)]
        public static unsafe void vxornot<T>(N256 n, in T rX, in T rY, ref T rDst)
            where T : unmanaged
                => vstore(vxornot(n, in rX, in rY), ref rDst);
    }
}