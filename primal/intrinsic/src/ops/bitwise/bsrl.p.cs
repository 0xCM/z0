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
        public static unsafe Vector128<T> vbsrl<T>(N128 n, T* pX, byte count)
            where T : unmanaged
        {                    
            vload(pX, out Vector128<T> vA);
            return vbsrl(vA,count);
        }

        [MethodImpl(Inline)]
        public static unsafe void vbsrl<T>(N128 n, T* pX, T* pDst, byte count)
            where T : unmanaged
                => vstore(vbsrl(n, pX,count), pDst);

        [MethodImpl(Inline)]
        public static unsafe Vector256<T> vbsrl<T>(N256 n, T* pX, byte count)
            where T : unmanaged
        {                    
            vload(pX, out Vector256<T> vA);
            return vbsrl(vA,count);
        }

        [MethodImpl(Inline)]
        public static unsafe void vbsrl<T>(N256 n, T* pX, T* pDst, byte count)
            where T : unmanaged
                => vstore(vbsrl(n, pX,count), pDst);

    }

}