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

    public class t_compress : BitPartTest<t_compress>
    {                    

        public void bb_pack_8()
        {
            
            var x = Random.Next<byte>();
            var y = BitBlock.Alloc<BitBlock8>().Data;            
            var z = x.ToBitVector(n8);
            y.Bit0 = z[0];
            y.Bit1 = z[1];
            y.Bit2 = z[2];
            y.Bit3 = z[3];
            y.Bit4 = z[4];
            y.Bit5 = z[5];
            y.Bit6 = z[6];            
            y.Bit7 = z[7];
            var c = y.Compress().ToBitVector();
            Claim.eq(c,x);



        }


    }
}