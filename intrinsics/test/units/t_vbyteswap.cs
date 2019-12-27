//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public class t_vbyteswap : t_vinx<t_vbyteswap>
    {   
        public void vbyteswap_basecase()
        {
            var x16 = CpuVector.vparts(n128, 
                0b0000000011111111, 0b1111111100000000, 
                0b1100110000110011, 0b0011001111001100,
                0b1000000000000000, 0b0000000010000000,                
                0b0000011100000111, 0b0000011100000111
                );
            var y16 = CpuVector.vparts(n128, 
                0b1111111100000000, 0b0000000011111111, 
                0b0011001111001100, 0b1100110000110011, 
                0b0000000010000000, 0b1000000000000000,                 
                0b0000011100000111, 0b0000011100000111 
                );

            var z16 = dinx.vbyteswap(x16);
            var z16s = z16.ToSpan();

            Claim.eq(y16,z16);            
            for(var i=0; i<z16s.Length; i+= 2)
                Claim.eq(Bits.byteswap(z16s[i]), z16s[i+1]);

            var x32 = CpuVector.vparts(n128, 
                0xFFFF0000, 0x0000FFFF,
                0xFF000000, 0x000000FF
                );
            var y32 = CpuVector.vparts(n128, 
                0x0000FFFF, 0xFFFF0000,
                0x000000FF, 0xFF000000
                );
            
            var z32 = dinx.vbyteswap(x32);
            Claim.eq(y32,z32);
        }


        public void sbyteswap_16()
        {
            for(var i=0; i< SampleCount; i++)
            {
                var a = Random.Next<ushort>();
                var b = Bits.byteswap(Bits.byteswap(a));
                Claim.eq(a,b);
            }
        }

        public void sbyteswap_32()
        {
            
            for(var i=0; i< SampleCount; i++)
            {
                var a = Random.Next<uint>();
                var b = Bits.byteswap(Bits.byteswap(a));
                Claim.eq(a,b);
            }
        }

        public void sbyteswap_64()
        {
            var a = (ulong)uint.MaxValue << 32;
            var b = (ulong)uint.MaxValue;
            Claim.eq(Bits.byteswap(a),b);
            Claim.eq(Bits.byteswap(b),a);
            
            for(var i=0; i< SampleCount; i++)
            {
                var x = Random.Next<ulong>();
                var y = Bits.byteswap(Bits.byteswap(x));
                Claim.eq(x,y);
            }
        }

        public void vbyteswap_128x32()
            => vbyteswap_check_256(n128,z32);

        public void vbyteswap_128x64()
            => vbyteswap_check_256(n128,z64);

        public void vbyteswap_128x16()
            => vbyteswap_check_256(n128,z16);

        public void vbyteswap_256x32()
            => vbyteswap_check_256(n256,z32);

        public void vbyteswap_256x16()
            => vbyteswap_check_256(n256,z16);

        public void vbyteswap_256x64()
            => vbyteswap_check_256(n256,z64);



    }
}