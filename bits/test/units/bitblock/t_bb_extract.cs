//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_bb_extract : t_bitblock<t_bb_extract>
    {
        public void bb_extract_64()
        {
            var src = Random.Stream<ulong>().Take(SampleCount).ToArray();
            var lower = Random.Stream(leftclosed<byte>(0,32)).Take(SampleCount).ToArray();
            var upper = Random.Stream(leftclosed<byte>(32,64)).Take(SampleCount).ToArray();
            for(var i=0; i< SampleCount; i++)
            {
                var v1 = BitBlocks.literals(src[i]);
                var v2 = BitVector.from(n64,src[i]);
                Claim.eq(v1.ToBitVector(n64), v2);

                var r1 = v1.Slice(lower[i], upper[i]);
                var r2 = v2[lower[i], upper[i]];

                if(r1 != r2)
                {
                    Trace($"v1 = {v1.ToBitString()}");
                    Trace($"v2 = {v2.ToBitString()}");

                    Trace($"v1[{lower[i]}, {upper[i]}] = {r1.ToBitString()}");
                    Trace($"v2[{lower[i]}, {upper[i]}] = {r2.ToBitString()}");
                }
                Claim.eq(r1,r2);                
            }
        }

        public void bb_extract_32()
        {
            var src = Random.Stream<uint>().Take(SampleCount).ToArray();
            var lower = Random.Stream(leftclosed<byte>(0,16)).Take(SampleCount).ToArray();
            var upper = Random.Stream(leftclosed<byte>(16,32)).Take(SampleCount).ToArray();
            for(var i=0; i< SampleCount; i++)
            {
                var v1 = BitBlocks.literals(src[i]);
                var v2 = BitVector.from(n32,src[i]);
                Claim.eq(v1.ToBitVector(n32),v2);

                var r1 = v1.Slice(lower[i], upper[i]);
                var r2 = v2[lower[i], upper[i]];
                Claim.eq(r1,r2);                
            }
        }

        public void bb_extract_16()
        {
            var src = Random.Stream<ushort>().Take(SampleCount).ToArray();
            var lower = Random.Stream(leftclosed<byte>(0,8)).Take(SampleCount).ToArray();
            var upper = Random.Stream(leftclosed<byte>(8,16)).Take(SampleCount).ToArray();
            for(var i=0; i< SampleCount; i++)
            {
                var v1 = BitBlocks.literals(src[i]);
                var v2 = BitVector.from(n16,src[i]);
                Claim.eq(v1.ToBitVector(n16),v2);

                var r1 = v1.Slice(lower[i], upper[i]);
                var r2 = v2[lower[i], upper[i]];
                Claim.eq(r1,r2);                
            }
        }

        public void bb_extract_aligned()
        {
            byte x0 = 0b11010110;
            byte x1 = 0b10010101;
            byte x2 = 0b10100011;
            byte x3 = 0b10011101;
            byte x4 = 0b01011000;
            var bcx = BitBlocks.literals(x0,x1,x2,x3,x4);
            Claim.eq(40, bcx.BitCount);

            byte y0 = 0b0110;
            byte y1 = 0b1101;
            var y01 = gmath.or(y0, gmath.sal(y1, 4));
            byte y2 = 0b0101;
            byte y3 = 0b1001;
            var y23 = gmath.or(y2, gmath.sal(y3, 4));
            byte y4 = 0b0011;
            byte y5 = 0b1010;
            var y45 = gmath.or(y4, gmath.sal(y5, 4));
            byte y6 = 0b1101;
            byte y7 = 0b1001;
            var y67 = gmath.or(y6, gmath.sal(y7, 4));
            byte y8 = 0b1000;
            byte y9 = 0b0101;
            var y89 = gmath.or(y8, gmath.sal(y9, 4));
            var bcy = BitBlocks.literals(y01,y23,y45,y67,y89);            
            Claim.eq(40, bcy.BitCount);

            ulong z = 0b0101100010011101101000111001010111010110;           
            var bvz = BitBlocks.literal(z,40);
            Claim.eq(40, bvz.BitCount);

            var bsy = bcy.ToBitString().Format(true);
            var bsx = bcx.ToBitString().Format(true);
            var bsz = bvz.ToBitString().Format(true);
            Claim.eq(bsx, "101100010011101101000111001010111010110");
            Claim.eq(bsx, bsy);
            Claim.eq(bsx, bsz);

            Claim.eq(y0, bcx.Slice(0,3));
            Claim.eq(y1, bcx.Slice(4,7));
            Claim.eq(y2, bcx.Slice(8,11));
            Claim.eq(y3, bcx.Slice(12,15));
            Claim.eq(y4, bcx.Slice(16,19));
            Claim.eq(y5, bcx.Slice(20,23));
            Claim.eq(y6, bcx.Slice(24,27));
            Claim.eq(y7, bcx.Slice(28,31));
            Claim.eq(y8, bcx.Slice(32,35));
            Claim.eq(y9, bcx.Slice(36,39));

            Claim.eq(y0, (byte)bvz.Slice(0,3));
            Claim.eq(y1, bvz.Slice(4,7));
            Claim.eq(y2, bvz.Slice(8,11));
            Claim.eq(y3, bvz.Slice(12,15));
            Claim.eq(y4, bvz.Slice(16,19));
            Claim.eq(y5, bvz.Slice(20,23));
            Claim.eq(y6, bvz.Slice(24,27));
            Claim.eq(y7, bvz.Slice(28,31));
            Claim.eq(y8, bvz.Slice(32,35));
            Claim.eq(y9, bvz.Slice(36,39));    
        }

        public void bb_extract_arb()
        {

            ulong z = 0b01011_00010_01110_11010_00111_00101_01110_10110;           
            var bvz = BitBlocks.literal(z,40);
            var xSrc =  BitConvert.GetBytes(z);
            Span<ushort> ySrc = xSrc.AsUInt16();
            Claim.eq(ySrc.Length*2, xSrc.Length);

            var bvx = BitBlocks.literals(xSrc.Slice(0,5).ToArray());
            var bvy = BitBlocks.literals(ySrc.Slice(0,2).ToArray());            
            var bsx = bvx.ToBitString().Format(true);
            var bsz = bvz.ToBitString().Format(true);
            Claim.eq(bsx, bsz);

            Claim.eq((byte)0b10110, bvx.Slice(0, 4));
            Claim.eq((byte)0b01110, bvx.Slice(5, 9));
            Claim.eq((byte)0b00101, bvx.Slice(10, 14));
            Claim.eq((byte)0b00111, bvx.Slice(15, 19));
            Claim.eq((byte)0b11010, bvx.Slice(20, 24));
            Claim.eq((byte)0b01110, bvx.Slice(25, 29));

            Claim.eq((ushort)0b10110, bvy.Slice(0, 4));
            Claim.eq((ushort)0b01110, bvy.Slice(5, 9));
            Claim.eq((ushort)0b00101, bvy.Slice(10, 14));
            Claim.eq((ushort)0b00111, bvy.Slice(15, 19));
            Claim.eq((ushort)0b11010, bvy.Slice(20, 24));
            Claim.eq((ushort)0b01110, bvy.Slice(25, 29));

            Claim.eq((ulong)0b10110, bvz.Slice(0, 4));
            Claim.eq((ulong)0b01110, bvz.Slice(5, 9));
            Claim.eq((ulong)0b00101, bvz.Slice(10, 14));
            Claim.eq((ulong)0b00111, bvz.Slice(15, 19));
            Claim.eq((ulong)0b11010, bvz.Slice(20, 24));
            Claim.eq((ulong)0b01110, bvz.Slice(25, 29));
        }
    }
}