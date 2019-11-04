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
        public static unsafe Vector128<T> vdec<T>(N128 n, in T pX)
            where T : unmanaged
        {                    
            vload(pX, out Vector128<T> vA);
            return vdec(vA);
        }

        [MethodImpl(Inline)]
        public static unsafe void vdec<T>(N128 n, in T pX, ref T pDst)
            where T : unmanaged
                => vstore(vdec(n,in pX), ref pDst);                    
                    
        [MethodImpl(Inline)]
        public static unsafe Vector256<T> vdec<T>(N256 n, in T pX)
            where T : unmanaged
        {                    
            vload(pX, out Vector256<T> vA);
            return vdec(vA);
        }

        [MethodImpl(Inline)]
        public static unsafe void vdec<T>(N256 n, in T pX, ref T pDst)
            where T : unmanaged
                => vstore(vdec(n,in pX), ref pDst);                    
    }
}