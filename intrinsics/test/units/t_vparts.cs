//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;

    public class t_vparts : t_vinx<t_vparts>
    {

        public void vpart_30x3()
        {
            // var x =  dinx.vpart30x8x3(uint.MaxValue);            
            // Trace(x.FormatBitBlocks());
            var count = 0b111_110_101_100_011_010_001_000u;

            var actual =  dinx.vpart30x8x3(count);            
            var expect = vbuild.parts(n256,0,1,2,3,4,5,6,7,0,0,0,0,0,0,0,0);
            Claim.eq(actual,expect);


        }

    }

}


