//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    
    
    partial class inxoc
    {                

        public static Vector128<byte> msb_mask_v128()
            => vmask.msb<byte>(n128,n8, 4);
            
        public static ulong sum_256x64u(Vector256<ulong> src)
            => dinx.vsum(src);

        public static ulong sum_256x64u(Vector128<ulong> src)
            => dinx.vsum(src);

        public static ulong pop64_scalar(ulong a, ulong b, ulong c, ulong d)
            => AvxPops.pop64(a,b,c,d);

        public static ulong pop64_vector(Vector256<ulong> x)
            => AvxPops.pop64(x);

        public static void vcsa_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c, out Vector256<ulong> lo, out Vector256<ulong> hi)
            => AvxPops.vcsa(a,b,c,out lo,out hi);

        public static void csa_64u(ulong a, ulong b, ulong c, out ulong lo, out ulong hi)
            => AvxPops.csa(a,b,c,out lo,out hi);

        public static void vtranspose(ref Vector128<uint> row0, ref Vector128<uint> row1, ref Vector128<uint> row2, ref Vector128<uint> row3)        
            => dinx.vtranspose(ref row0, ref row1, ref row2, ref row3);

    }

}