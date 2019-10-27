//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;

    public class t_vsllv : IntrinsicTest<t_vsllv>
    {

        public void Nonzero()
        {
            Claim.yea(ginx.vnonz(cpuvec(1ul, 2ul, 3ul, 4ul)));
            Claim.yea(ginx.vnonz(cpuvec(1ul, 0ul, 0ul, 0ul)));
            Claim.nea(ginx.vnonz(cpuvec(0ul, 0ul, 0ul, 0ul)));

            Claim.yea(ginx.vnonz(cpuvec(1u, 2u, 3u, 4u)));
            Claim.yea(ginx.vnonz(cpuvec(1u, 0u, 0u, 0u)));
            Claim.nea(ginx.vnonz(cpuvec(0u, 0u, 0u, 0u)));
        }


    }

}