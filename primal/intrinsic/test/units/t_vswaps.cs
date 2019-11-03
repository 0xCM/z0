//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.IO;
    
    using static zfunc;
    using static nfunc;

    public class t_vswaps : IntrinsicTest<t_vswaps>
    {
        
        public void transpose_check()
        {
            var a = ginx.vincrements(n128, 0u);
            var b = ginx.vincrements(n128, 4u);
            var c = ginx.vincrements(n128, 8u);
            var d = ginx.vincrements(n128, 12u);
            var x0 = dinx.vunpacklo(v8u(a), v8u(b));
            var y0 = dinx.vunpacklo(v8u(c), v8u(d));
            var z0 = v8u(dinx.vunpacklo(v16u(x0),v16u(y0)));
            var z1 = v8u(dinx.vunpackhi(v16u(x0),v16u(y0)));
            var x1 = dinx.vunpackhi(v8u(a), v8u(b));
            var y1 = dinx.vunpackhi(v8u(c), v8u(d));
            var z2 = v8u(dinx.vunpacklo(v16u(x1),v16u(y1)));
            var z3 = v8u(dinx.vunpackhi(v16u(x1),v16u(y1)));
                            
        }

        public void transpose_4x4_check()
        {
            var order = n4;        
            var cells = order*order;
            var src = new uint[cells];
            var n = n128;
            int step = order;
        
            for(var i=0u; i< cells; i++)
                src[i] = i;

            var a = ginx.vload(n, head(ref src), step*0);
            var b = ginx.vload(n, head(ref src), step*1);
            var c = ginx.vload(n, head(ref src), step*2);
            var d = ginx.vload(n, head(ref src), step*3);
            dinx.vtranspose(ref a, ref b, ref c, ref d);
            
            
            var dst = new uint[cells];
            ginx.vstore(a, ref head(ref dst), step*0);
            ginx.vstore(b, ref head(ref dst), step*1);
            ginx.vstore(c, ref head(ref dst), step*2);
            ginx.vstore(d, ref head(ref dst), step*3);

            var A = Matrix.load(order, src);
            var B = Matrix.load(order, dst);
            for(var i=0; i < order; i++)
            for(var j=0; j < order; j++)
                Claim.eq(A[i,j], B[j,i]);

        }

        public void shift_test()
        {
            var m = dinx.vbroadcast(n128, (ushort)0xFF);
            var x = ginx.vincrements<byte>(n128);
            dinx.vconvert(x, out Vector256<ushort> y);
            var z = dinx.vsll(y,1);
            Trace(z.Format());
            var z0 = dinx.vand(dinx.vlo(z),m);
            var z1 = dinx.vand(dinx.vhi(z),m);
            Trace(z0.Format());
            Trace(z1.Format());
        }

        public void convert_check()
        {
            var x128 = ginx.vincrements<byte>(n128);
            var x256 = ginx.vincrements<byte>(n256);
            dinx.vconvert(x128, out Vector128<ushort> a1);
            dinx.vconvert(x128, out Vector128<uint> a2);
            dinx.vconvert(x128, out Vector128<ulong> a3);
            dinx.vconvert(x128, out Vector256<ushort> b1);
            dinx.vconvert(x128, out Vector256<uint> b2);
            dinx.vconvert(x128, out Vector256<ulong> b3);


        }

        public void perm_swaps()
        {            
            
            var src = ginx.vincrements<byte>(n128);

            Swap s = (0,1);
            var x1 = dinx.vswap(src, s);
            var x2 = dinx.vswap(x1, s);
            Claim.eq(x2, src);

            //Shuffle the first element all the way through to the last element
            var chain = Swap.Chain((0,1), 15);
            var x3 = dinx.vswap(src, chain).ToSpan();
            Claim.eq(x3[15],(byte)0);            
        }

    }
}