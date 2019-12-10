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

    public class t_vswaps : t_vinx<t_vswaps>
    {        
        public void transpose_check()
        {
            var a = dinx.vparts(n128, 0u,1,2,3);
            var b = dinx.vparts(n128, 4u,5,6,7);
            var c = dinx.vparts(n128, 8u,9,10,11);
            var d = dinx.vparts(n128, 12u,13,14,15);
            var x0 = dinx.vmergelo(v8u(a), v8u(b));
            var y0 = dinx.vmergelo(v8u(c), v8u(d));
            var z0 = v8u(dinx.vmergelo(v16u(x0),v16u(y0)));
            var z1 = v8u(dinx.vmergehi(v16u(x0),v16u(y0)));
            var x1 = dinx.vmergehi(v8u(a), v8u(b));
            var y1 = dinx.vmergehi(v8u(c), v8u(d));
            var z2 = v8u(dinx.vmergelo(v16u(x1),v16u(y1)));
            var z3 = v8u(dinx.vmergehi(v16u(x1),v16u(y1)));                            
        }

        public void transpose_4x4_check()
        {
            var order = n4;        
            var n = n128;
            var cells = order*order;
            var src = DataBlocks.alloc<uint>(n,order);
            int step = order;

            for(var i=0; i< cells; i++)
                src[i] = (uint)i;

            var a = src.LoadVector(0);
            var b = src.LoadVector(1);
            var c = src.LoadVector(2);
            var d = src.LoadVector(3);
            dinx.vtranspose(ref a, ref b, ref c, ref d);
            
            
            var dst = new uint[cells];
            ginx.vstore(a, ref head(dst), step*0);
            ginx.vstore(b, ref head(dst), step*1);
            ginx.vstore(c, ref head(dst), step*2);
            ginx.vstore(d, ref head(dst), step*3);

            var A = Matrix.load(order, src.ToArray());
            var B = Matrix.load(order, dst);
            for(var i=0; i < order; i++)
            for(var j=0; j < order; j++)
                Claim.eq(A[i,j], B[j,i]);
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