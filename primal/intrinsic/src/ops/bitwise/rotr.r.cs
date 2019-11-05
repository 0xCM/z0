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
        public static unsafe Vector128<T> vrotr<T>(N128 n, in T pX, byte offset)
            where T : unmanaged
        {                    
            vload(pX, out Vector128<T> vA);
            return vrotr(vA,offset);
        }

        [MethodImpl(Inline)]
        public static unsafe void vrotr<T>(N128 n, in T pX, byte offset, ref T pDst)
            where T : unmanaged
                => vstore(vrotr(n, in pX, offset), ref pDst);


        [MethodImpl(Inline)]
        public static unsafe Vector256<T> vrotr<T>(N256 n, in T pX, byte offset)
            where T : unmanaged
        {                    
            vload(pX, out Vector256<T> vA);
            return vrotr(vA,offset);
        }

        [MethodImpl(Inline)]
        public static unsafe void vrotr<T>(N256 n, in T pX, byte offset, ref T pDst)
            where T : unmanaged
                => vstore(vrotr(n,in pX, offset), ref pDst);
    }
}