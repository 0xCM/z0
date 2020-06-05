//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public class t_encode : UnitTest<t_encode>
    {        
        public void encode_asci16()
        {
            var tc = default(AsciTestCase01);
            var result = AsciTestCases.execute(tc);
            Trace(result.Description);
            Claim.yea(result.Success);
        }
    }
}
