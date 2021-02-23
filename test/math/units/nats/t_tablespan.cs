//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public class t_tablespan : UnitTest<t_tablespan>
    {
        public void transpose_4x3()
        {
            var m = nat8u<N4>();
            var n = nat8u<N3>();

            for(var rep=0; rep<RepCount; rep++)
            {
                var src = Random.TableSpan(n4, n3, Interval.closed(1,1000));
                Claim.eq(src.Dim.I, m);
                Claim.eq(src.Dim.J, n);

                var dst = src.Transpose();
                Claim.eq(dst.Dim.I, n);
                Claim.eq(dst.Dim.J, m);

                for(var i=0; i< m; i++)
                for(var j=0; j < n; j++)
                    Claim.eq(src[i,j], dst[j,i]);
            }
        }

        public void transpose_12x12()
        {
            var m = n12;
            var n = n12;

            for(var rep=0; rep<RepCount; rep++)
            {
                var src = Random.TableSpan(m, n, Interval.closed(1,1000));
                Claim.eq(src.Dim.I, m);
                Claim.eq(src.Dim.J, n);

                var dst = src.Transpose();
                Claim.eq(dst.Dim.I, n);
                Claim.eq(dst.Dim.J, m);

                for(var i=0; i< m; i++)
                for(var j=0; j < n; j++)
                    Claim.eq(src[i,j], dst[j,i]);
            }
        }
    }
}