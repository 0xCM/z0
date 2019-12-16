//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public class t_vswaps : t_vinx<t_vswaps>
    {        

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

    }
}