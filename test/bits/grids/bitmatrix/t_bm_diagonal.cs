//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;
    
    public class t_bm_diagonal : t_bm<t_bm_diagonal>
    {

        public void bm_diagonal_4x4x4()
        {
            for(var i=0; i<RepCount; i++)
            {
                var A = Random.BitMatrix(n4);
                var x = BitMatrix.diagonal(A);
                var y = BitVector.alloc(n4);
                for(byte j = 0; j< A.Order; j++)
                    y[j] = A[j,j];
                Claim.eq(x,y);
            }
        }

        public void bm_diagonal_8x8x8()
        {
            for(var i=0; i<RepCount; i++)
            {
                var A = Random.BitMatrix(n8);
                var x = BitMatrix.diagonal(A);
                var y = BitVector.alloc(n8);
                for(var j = 0; j< A.Order; j++)
                    y[j] = A[j,j];
                Claim.eq(x,y);
            }
        }
    }
}