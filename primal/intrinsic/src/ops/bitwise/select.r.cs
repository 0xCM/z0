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
    
    using static zfunc;    
    using static As;
    

    partial class ginx
    {

        [MethodImpl(Inline)]
        public static unsafe Vector128<T> vselect<T>(N128 n, in T rX, in T rY, in T rZ)
            where T : unmanaged
        {                    
            vload(rX, out Vector128<T> vA);
            vload(rY, out Vector128<T> vB);
            vload(rZ, out Vector128<T> vC);
            return vselect(vA,vB,vC);
        }

        [MethodImpl(Inline)]
        public static unsafe void vselect<T>(N128 n, in T rX, in T rY, in T rZ, ref T rDst)
            where T : unmanaged
                => vstore(vselect(n, in rX, in rY, in rZ), ref rDst);

        [MethodImpl(Inline)]
        public static unsafe Vector256<T> vselect<T>(N256 n, in T rX, in T rY, in T rZ)
            where T : unmanaged
        {                    
            vload(rX, out Vector256<T> vA);
            vload(rY, out Vector256<T> vB);
            vload(rZ, out Vector256<T> vC);
            return vselect(vA,vB,vC);
        }

        [MethodImpl(Inline)]
        public static unsafe void vselect<T>(N256 n, in T rX, in T rY, in T rZ, ref T rDst)
            where T : unmanaged
                => vstore(vselect(n, in rX, in rY, in rZ), ref rDst);

    }

}