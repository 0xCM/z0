//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;

    using static Konst;

    public class t_potrf : UnitTest<t_potrf>
    {
        public void posdef1()
        {
            var notPD = Matrix.blockload(new float[]{1,2,2,1}, n2);
            var eval1 = mkl.posdef(notPD);
            Claim.nea(eval1);

            var PD = Matrix.blockload(new float[]{2,-1,0,-1,2,-1,0,-1,2}, n3);
            var eval2 = mkl.posdef(PD);
            Claim.require(eval2);

        }

        public void posdef2()
        {
            var A = Matrix.blockload(new float[]{4,12,-16,12,37,-43,-16,-43,98}, n3);
            var B = A.Replicate();
            Claim.require(mkl.potrf(B));
        }
    }
}