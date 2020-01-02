//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public class t_abs : t_libm<t_abs>
    {

        public void fabs64_libm_validate()
        {
            for(var i=0; i<RepCount; i++)
            {
                var src = Random.Next<double>();
                Claim.eq(src < 0 ? -src : src, fmath.abs(src));
                Claim.eq(fmath.abs(src), libm.fabs(src));
            }
        }

    }

}