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
        public static unsafe bool vnonz<T>(N128 n, in T rX)
            where T : unmanaged
        {                    
            vload(rX, out Vector128<T> vA);
            return vnonz(vA);
        }

        [MethodImpl(Inline)]
        public static unsafe bool vnonz<T>(N256 n, in T rX)
            where T : unmanaged
        {                    
            vload(rX, out Vector256<T> vA);
            return vnonz(vA);
        }


    }

}