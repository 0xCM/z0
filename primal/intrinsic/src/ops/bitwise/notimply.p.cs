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
        public static unsafe Vector128<T> vnotimply<T>(N128 n, T* pX, T* pY)
            where T : unmanaged
        {                    
            vload(pX, out Vector128<T> vA);
            vload(pY, out Vector128<T> vB);
            return vnotimply(vA,vB);
        }

        [MethodImpl(Inline)]
        public static unsafe void vnotimply<T>(N128 n, T* pX, T* pY, T* pZ)
            where T : unmanaged
                => vstore(vnotimply(n, pX,pY), pZ);

        [MethodImpl(Inline)]
        public static unsafe Vector256<T> vnotimply<T>(N256 n, T* pX, T* pY)
            where T : unmanaged
        {                    
            vload(pX, out Vector256<T> vA);
            vload(pY, out Vector256<T> vB);
            return vnotimply(vA,vB);
        }

        [MethodImpl(Inline)]
        public static unsafe void vnotimply<T>(N256 n, T* pX, T* pY, T* pZ)
            where T : unmanaged
                => vstore(vnotimply(n, pX,pY), pZ);

    }

}