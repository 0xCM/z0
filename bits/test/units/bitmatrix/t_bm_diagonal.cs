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
    
    public class t_bm_diagonal : t_bm<t_bm_diagonal>
    {

        public void diagonal_4x4()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var A = Random.BitMatrix(n4);
                var x = BitMatrix.diagonal(A);
                var y = BitVector.alloc(n4);
                for(var j = 0; j< A.Order; j++)
                    y[j] = A[j,j];
                Claim.eq(x,y);
            }
        }

        public void diagonal_8x8()
        {
            for(var i=0; i<SampleSize; i++)
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