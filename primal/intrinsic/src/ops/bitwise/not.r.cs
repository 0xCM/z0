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
        public static unsafe Vector128<T> vnot<T>(N128 n, in T rX)
            where T : unmanaged
        {                    
            vload(rX, out Vector128<T> vA);
            return vnot(vA);
        }

        [MethodImpl(Inline)]
        public static unsafe void vnot<T>(N128 n, in T rX, ref T rDst)
            where T : unmanaged
                => vstore(vnot(n, in rX),ref rDst);

        [MethodImpl(Inline)]
        public static unsafe Vector256<T> vnot<T>(N256 n, in T rX)
            where T : unmanaged
        {                    
            vload(rX, out Vector256<T> vA);
            return vnot(vA);
        }

        [MethodImpl(Inline)]
        public static unsafe void vnot<T>(N256 n, in T rX, ref T rDst)
            where T : unmanaged
                => vstore(vnot(n, in rX),ref rDst);
    }

}