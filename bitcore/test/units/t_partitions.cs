//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;

    public class t_partitions : t_bitcore<t_partitions>    
    {            
        public void bitpart_16x4()
        {
            var n = n4;
            var t = z8;
            var src = BitMask.msb(n2,n1,z16);
            var dst = NatSpan.alloc(n,t);
            Bits.part16x4(src, dst);
            var segment = uint8(0b1010).ToBitSpan();
            var expect = segment.Replicate(4);
            var actual = dst.Data.ToBitSpan();
            Claim.yea(expect.Equals(actual));
                        
        }

        public void bitpart_24x3()
        {
            var n = n8;
            var t = z8;

            var src = uint.MaxValue;
            var dst = NatSpan.alloc(n,t);
            
            Bits.part24x3(src, dst);
            for(var i=0; i<n; i++)
                Claim.eq(dst[i],(byte)7);
        }

        public void bitpart_27x3()
        {
            var n = n9;
            var t = z8;

            var src = uint.MaxValue;
            var dst = NatSpan.alloc(n,t);
            
            Bits.part27x3(src, dst);

            var expect = BitSpan.parse("000001110000011100000111000001110000011100000111000001110000011100000111");
            var actual = dst.Data.ToBitSpan();

            Trace(expect.Format());
            Trace(actual.Format());

            for(var i=0; i<n; i+= 3)
            {
                Claim.eq(expect[i],actual[i]);
                Claim.eq(expect[i+1],actual[i+1]);
                Claim.eq(expect[i+2],actual[i+2]);
            }
                        
        }

        public void bitpart_30x3()
        {
            var n = n10;
            var t = z8;

            var src = uint.MaxValue;
            var dst = NatSpan.alloc(n,t);
            
            Bits.part30x3(src, dst);
            for(var i=0; i<n; i++)
                Claim.eq(dst[i],(byte)7);
        }

        public void bitpart_63x3()
        {
            var n = n21;
            var t = z8;


            var src = ulong.MaxValue;
            var dst = NatSpan.alloc(n,t);
            Bits.part63x3(src, dst);
            for(var i=0; i<n; i++)
                Claim.eq(dst[i],(byte)7);
        }




    }

}