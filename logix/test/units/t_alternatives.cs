//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public class t_alternatives : UnitTest<t_alternatives>
    {

        public void alt_4x4()
        {
            //16 decisions each of which can branch 4 ways
            var count = 16;
            var decisions = Random.BitVectors(n4).Take(count).ToSpan();
            Span<BitVector4> identifiers = new BitVector4[count];
            for(var i=0; i< count; i++)
                identifiers[i] = (byte)i;
            
            Span<BitVector8> branches = new BitVector8[count];
            for(var i=0; i<count; i++)
                branches[i] = identifiers[i].Concat(decisions[i]);

            var bm = BitGrid.load(n16, branches);
            Trace(bm.Format());

        }

        public void create_grid()
        {
            Span<BitVector8> dst = new BitVector8[20];
            for(var i=0; i<20; i++)
                dst[i] = (byte)i;

            var bg = BitGrid.load(n20, dst);
            for(var i=0; i< dst.Length; i++)
            {
                
            }


        }

    }

}
