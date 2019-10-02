//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;

    using static zfunc;
    using static BitParts;

    public class t_bitblocks : BitPartTest<t_bitblocks>
    {

        public void bb_set64()
        {
            var x = Random.Next<ulong>().ToBitVector();
            var y = BitBlock.Alloc<BitBlock64>();
            for(var i=0; i<x.Length; i++)
                y[i] = x[i];

            
            

        }

    }

}
        
