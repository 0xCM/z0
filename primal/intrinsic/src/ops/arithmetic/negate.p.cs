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
        public static unsafe Vector128<T> vnegate<T>(N128 n, T* pX)
            where T : unmanaged
        {                    
            vload(pX, out Vector128<T> vA);
            return vnegate(vA);
        }

        [MethodImpl(Inline)]
        public static unsafe void vnegate<T>(N128 n, T* pX, T* pDst)
            where T : unmanaged
             => vstore(vnegate(n, pX), pDst);

        [MethodImpl(Inline)]
        public static unsafe Vector256<T> vnegate<T>(N256 n, T* pX)
            where T : unmanaged
        {                    
            vload(pX, out Vector256<T> vA);
            return vnegate(vA);
        }

        [MethodImpl(Inline)]
        public static unsafe void vnegate<T>(N256 n, T* pX, T* pDst)
            where T : unmanaged
              => vstore(vnegate(n, pX), pDst);
   }
}