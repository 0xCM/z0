//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl.Test
{
    using System;

    public class t_geev : UnitTest<t_geev>
    {
        public void test1()
        {

            var A = Random.MatrixBlock<N5,double>();
            var eigen = mkl.geev<N5>(A);
            Claim.eq(5,eigen.Values.Count);

        }
    }
}