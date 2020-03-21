//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    public class t_exp : t_libm<t_exp>
    {

        const double MinExp = 2.0;
        const double MaxExp = 50.0;

        public void exp_libm_valid()
        {
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.Next<double>(MinExp, MaxExp);
                var y = libm.exp(x);
                var z = fmath.exp(x);
                var error = fmath.relerr(y,z).Round(10);
                Claim.zero(error);
            }
        }


    }

}