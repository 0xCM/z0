//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;
    
    public class t_bm_outer : t_bm<t_bm_outer>
    {

        public void outer_product_32()
        {
            const uint fill = 0x55555555;
            
            var u = fill.ToBitVector();
            var v = fill.ToBitVector();
            var z = BitVector.oprod(u,v).ToNatural();

            Span<uint> ys = new uint[v];            

            var A = BitMatrix.alloc(n32,n1,0u);
            for(var i=0; i<A.RowCount; i++)
                A[i,0] = u[i];
            var B = BitMatrix.alloc(n1,n32,v.Scalar);
            var C = BitMatrix.mul(A,B).AsSquare();

            Claim.yea(C == z);
        
        }

    }

}