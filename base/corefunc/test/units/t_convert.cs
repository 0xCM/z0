//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using System.Runtime.CompilerServices;
    using static zfunc;

    public sealed class t_convert : UnitTest<t_convert>
    {

        public void convert_64f_to32i()
        {
            var x = 32.44;
            var y0 = convert<int>(x);
            var y1 = convert<double,int>(x);
            Claim.eq((int)x,y0);
            Claim.eq(y0,y1);
        }

    }

}