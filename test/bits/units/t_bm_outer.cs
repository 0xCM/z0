//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;


    public class t_bm_outer : t_bitmatrix<t_bm_outer>
    {
        public void outer_product_32()
        {
            const uint fill = 0x55555555;

            var u = fill.ToBitVector32();
            var v = fill.ToBitVector32();
            var z = BitMatrix.oprod(u,v).ToNatural();

            Span<uint> ys = new uint[v];

            var A = BitMatrix.alloc(n32,n1,0u);
            for(var i=0; i<A.RowCount; i++)
                A[i,0] = u[i];
            var B = BitMatrix.init(v.Content,n1,n32);
            var C = BitMatrix.mul(A,B).AsSquare();

            Claim.Require(C == z);
        }
    }
}