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
        public static unsafe Vector128<T> vsll<T>(N128 n, in T pX, byte offset)
            where T : unmanaged
        {                    
            vload(pX, out Vector128<T> vA);
            return vsll(vA,offset);
        }

        [MethodImpl(Inline)]
        public static unsafe void vsll<T>(N128 n, in T pX, byte offset, ref T pDst)
            where T : unmanaged
                => vstore(vsll(n, in pX, offset), ref pDst);


        [MethodImpl(Inline)]
        public static unsafe Vector256<T> vsll<T>(N256 n, in T pX, byte offset)
            where T : unmanaged
        {                    
            vload(pX, out Vector256<T> vA);
            return vsll(vA,offset);
        }

        [MethodImpl(Inline)]
        public static unsafe void vsll<T>(N256 n, in T pX, byte offset, ref T pDst)
            where T : unmanaged
                => vstore(vsll(n,in pX, offset), ref pDst);
    }
}