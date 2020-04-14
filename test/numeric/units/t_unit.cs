//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Seed;
    using static Memories;

    public class t_nonzero : t_numeric<t_nonzero>
    {
        public void nonzero_create()
        {
            Claim.nonzero(Numeric.nonzero(0u).Value);            

            Claim.eq(Numeric.nonzero(5), 5);

        }
    }
}


