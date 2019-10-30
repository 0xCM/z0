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
    using System.Runtime.Intrinsics;
    using System.IO;
    
    using static zfunc;
    using static nfunc;

    public class t_vperm4x64 : IntrinsicTest<t_vperm4x64>
    {

        public void perm4x64_256x64u_methodical()
        {
            var x = vparts(1ul,2,3,4);
            
            var y = dinx.vperm4x64(x, Perm4.ABCD);
            Claim.eq(vparts(1ul,2,3,4),y);            
            
            y = dinx.vperm4x64(x, Perm4.ABDC);
            Claim.eq(vparts(1ul,2,4,3), y);

            y = dinx.vperm4x64(x, Perm4.ACBD);
            Claim.eq(vparts(1ul,3,2,4), y);

            y = dinx.vperm4x64(x, Perm4.ACDB);
            Claim.eq(vparts(1ul,3,4,2), y);

            y = dinx.vperm4x64(x, Perm4.ADBC);
            Claim.eq(vparts(1ul,4,2,3), y);

            y = dinx.vperm4x64(x, Perm4.ADCB);
            Claim.eq(vparts(1ul,4,3,2), y);

        }

        public void perm4x64_256x64u_randomized()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var src = Vec256Pattern.increments<ulong>();
                var x = dinx.vperm4x64(src, Perm4.BADC);
                var srcs = src.ToSpan();
                var y = Vector256.Create(srcs[1], srcs[0], srcs[3], srcs[2]);
                Claim.eq(x,y);
            }
        }
    }
}