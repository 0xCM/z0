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
        public static Vector128<T> vbsrl<T>(N128 n, in T rX, byte count)
            where T : unmanaged
        {                    
            vload(in rX, out Vector128<T> vA);
            return vbsrl(vA, count);
        }

        [MethodImpl(Inline)]
        public static unsafe void vbsrl<T>(N128 n, in T rX, byte count, ref T rDst)
            where T : unmanaged
                => vstore(vbsrl(n, in rX, count), ref rDst);

        [MethodImpl(Inline)]
        public static Vector256<T> vbsrl<T>(N256 n, in T rX, byte count)
            where T : unmanaged
        {                    
            vload(in rX, out Vector256<T> vA);
            return vbsrl(vA,count);
        }

        [MethodImpl(Inline)]
        public static unsafe void vbsrl<T>(N256 n, in T rX, byte count, ref T rDst)
            where T : unmanaged
                => vstore(vbsrl(n, in rX, count), ref rDst);
    }
}