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
        public static unsafe Vector128<T> vnot<T>(N128 n, T* pX)
            where T : unmanaged
        {                    
            vloadu(pX, out Vector128<T> vA);
            return vnot(vA);
        }

        [MethodImpl(Inline)]
        public static unsafe void vnot<T>(N128 n, T* pX, T* pDst)
            where T : unmanaged
                => vstore(vnot(n, pX),pDst);

        [MethodImpl(Inline)]
        public static unsafe Vector256<T> vnot<T>(N256 n, T* pX)
            where T : unmanaged
        {                    
            vloadu(pX, out Vector256<T> vA);
            return vnot(vA);
        }

        [MethodImpl(Inline)]
        public static unsafe void vnot<T>(N256 n, T* pX, T* pDst)
            where T : unmanaged
                => vstore(vnot(n, pX),pDst);
    }

}