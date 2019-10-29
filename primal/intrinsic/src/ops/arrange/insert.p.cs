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
        public static unsafe Vector256<T> vinsert<T>(T* pSrc, T* pReceiver, byte index)
            where T : unmanaged
        {                    
            vloadu(pSrc, out Vector128<T> vA);
            vloadu(pReceiver, out Vector256<T> vB);
            return vinsert(vA,vB, index);
        }

        [MethodImpl(Inline)]
        public static unsafe void vinsert<T>(N256 n, T* pSrc, T* pReceiver, byte index, T* pDst)
            where T : unmanaged
                => vstore(vinsert(pSrc,pReceiver,index), pDst);                    
    }
}