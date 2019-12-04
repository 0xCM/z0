//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static zfunc;

    public class t_abs : t_gmath<t_abs>
    {                
        public void abs_8i()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var src = Random.Next<sbyte>();
                Claim.eq(gmath.abs(src),Math.Abs(src));
            }
        }

        public void abs_16i()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var src = Random.Next<short>();
                Claim.eq(gmath.abs(src),Math.Abs(src));
            }
        }

        public void abs_32i()
        {

            for(var i=0; i<SampleSize; i++)
            {
                var src = Random.Next<int>();
                Claim.eq(gmath.abs(src),Math.Abs(src));
            }

        }

        public void abs_64i()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var src = Random.Next<long>();
                Claim.eq(gmath.abs(src),Math.Abs(src));
            }

        }
    }
}