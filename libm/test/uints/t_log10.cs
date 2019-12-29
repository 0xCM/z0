//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public class t_log10 : t_libm<t_log10>
    {
        public void log10_libm_validate()
        {
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.Next<double>();
                var y = libm.log10(x);
                var z = fmath.log(x);
                var error = fmath.relerr(y,z).Round(10);
                Claim.zero(error);
            }
        }


    }

}