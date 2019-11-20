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
    using static HexConst;


    public class t_vcstore : IntrinsicTest<t_vcstore>
    {   
        const byte Y = Pow2.T07;
        const byte N = 0;

        public void vcstore_128x8_basecase()
        {
            var x = dinx.vparts(n128,0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F);
            var mE = dinx.vparts(n128,Y,N,Y,N,Y,N,Y,N,Y,N,Y,N,Y,N,Y,N);
            var mO = dinx.vparts(n128,N,Y,N,Y,N,Y,N,Y,N,Y,N,Y,N,Y,N,Y);

            var expectE = MemBlocks.cells(n128,0,0,2,0,4,0,6,0,8,0,A,0,C,0,E,0);
            var actualE = MemBlocks.alloc<byte>(n128);            
            dinx.vcstore(x, mE, ref actualE.Head);
            Claim.eq(expectE,actualE);

            var expectO = MemBlocks.cells(n128,0,1,0,3,0,5,0,7,0,9,0,B,0,D,0,F);
            var actualO = MemBlocks.alloc<byte>(n128);            
            dinx.vcstore(x, mO, ref actualO.Head);
            Claim.eq(expectO,actualO);
            
            var expect = MemBlocks.cells(n128,0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F);
            var actual = MemBlocks.alloc<byte>(n128);            
            dinx.vcstore(x, mE, ref actual.Head);
            dinx.vcstore(x, mO, ref actual.Head);
            Claim.eq(expect,actual);

        }

    }

}