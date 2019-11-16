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
            Claim.yea(ginx.vnonz(dinx.vparts(n256, 1, 2, 3, 4)));
            Claim.yea(ginx.vnonz(dinx.vparts(n256, 1, 0, 0, 0)));
            Claim.nea(ginx.vnonz(dinx.vparts(n256, 0, 0, 0, 0)));

            Claim.yea(ginx.vnonz(dinx.vparts(n128, 1, 2, 3, 4)));
            Claim.yea(ginx.vnonz(dinx.vparts(n128, 1, 0, 0, 0)));
            Claim.nea(ginx.vnonz(dinx.vparts(n128, 0, 0, 0, 0)));
        }


    }

}