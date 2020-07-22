//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class t_split : t_bitcore<t_split>
    {
        public void sb_part_64x1()
        {
            var src = ulong.MaxValue;
            Span<bit> dst = new bit[64];
            Bits.part64x1(src,dst);
            for(var i=0; i< dst.Length; i++)
                Claim.Require(dst[i]);
        }

        public void sb_split_16x8()
        {
            var src = Random.Span<ushort>(RepCount);
            foreach(var x in src)
            {
                Bits.split(x,out var x0, out var x1);
                var y = Bits.concat(x0, x1);
                Claim.Eq(x,y);
                Claim.Eq(x, Unsigned.u16(new byte[]{x0, x1}));
            }
        }

        public void sb_split_32x8()
        {
            var src = Random.Span<uint>(RepCount);
            foreach(var x in src)
            {
                Bits.split(x, out var x0, out var x1, out var x2, out var x3);
                var y = Bits.concat(x0, x1, x2, x3);
                Claim.Eq(x,y);
                Claim.Eq(x, Unsigned.u32(new byte[]{x0, x1, x2, x3}));
            }
        }

        public void sb_split_64x8()
        {
            static ref byte pack(byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7, byte pos, ref byte dst)
            {
                if(gbits.testbit(x0, pos)) 
                    dst = Bits.enable(dst, 0);
                if(gbits.testbit(x1, pos)) 
                    dst = Bits.enable(dst, 1);
                if(gbits.testbit(x2, pos)) 
                    dst = Bits.enable(dst, 2);
                if(gbits.testbit(x3, pos)) 
                    dst = Bits.enable(dst, 3);
                if(gbits.testbit(x4, pos)) 
                    dst = Bits.enable(dst, 4);
                if(gbits.testbit(x5, pos)) 
                    dst = Bits.enable(dst, 5);
                if(gbits.testbit(x6, pos)) 
                    dst = Bits.enable(dst, 6);
                if(gbits.testbit(x7, pos)) 
                    dst = Bits.enable(dst, 7);
                return ref dst;
            }

            var src = Random.Span<ulong>(Pow2.T11);
            foreach(var x in src)
            {
                Bits.split(x, out var x0, out var x1, out var x2, out var x3, out var x4, out var x5, out var x6, out var x7);
                var y = Bits.concat(x0, x1, x2, x3, x4, x5, x6, x7);
                Claim.Eq(x,y);
                Claim.Eq(x, BitConverter.ToUInt64(new byte[]{x0, x1, x2, x3, x4, x5, x6, x7}));

                for(var i=0; i<8; i++)
                {
                    var dst = (byte)0;
                    var pos = (byte)(Pow2.pow(i) - 1);
                    pack(x0, x1, x2, x3, x4, x5, x6, x7, pos, ref dst);
                    
                    byte j = 0;
                    Claim.Require(gbits.bitmatch(dst, j++, x0, pos));
                    Claim.Require(gbits.bitmatch(dst, j++, x1, pos));
                    Claim.Require(gbits.bitmatch(dst, j++, x2, pos));
                    Claim.Require(gbits.bitmatch(dst, j++, x3, pos));
                    Claim.Require(gbits.bitmatch(dst, j++, x4, pos));
                    Claim.Require(gbits.bitmatch(dst, j++, x5, pos));
                    Claim.Require(gbits.bitmatch(dst, j++, x6, pos));
                    Claim.Require(gbits.bitmatch(dst, j++, x7, pos));                    
                }
            }

        }



        public void sb_pack_split_16()
        {
            var len = Pow2.T08;
            var lhs = Random.Array<byte>(len);
            var rhs = Random.Array<byte>(len);
            for(var i=0; i<len; i++)
            {
                var dst = Bits.concat(lhs[i], rhs[i]);
                Bits.split(dst,out var x0, out var x1);
                
                Claim.Eq(x0, lhs[i]);
                Claim.Eq(x1, rhs[i]);
            }        
        }

        public void sb_unpack_8x1()
        {
            for(var i=0; i<= 255; i++)            
            {
                byte b = (byte)i;
                var x = BitStore.bitseq(b);
                var y = BitStore.select(b);
                ClaimNumeric.eq(x,y);

                var up1 = BitStore.select((byte)i);
                Span<byte> up2 = stackalloc byte[8];
                Bits.unpack8x1(b, up2);
                Claim.eq(BitString.load(up1), BitString.load(up2));
            }
        }

        public void sb_unpack_64x1()
        {
            Span<byte> dst = stackalloc byte[64];

            for(var i=0; i< RepCount; i++)
            {
                var src = Random.Next<ulong>();
                Bits.unpack64x1(src, dst);
                var bitsPC = dst.PopCount();
                var bytes = z.bytes(src);
                var bytesPC = bytes.PopCount();
                Claim.Eq(bitsPC, bytesPC);        
            }
        }

        public void sb_unpack_32x1()
        {
            Span<byte> y1 = stackalloc byte[32];
            Span<byte> y2 = stackalloc byte[32];
            for(var i=0; i< RepCount; i++)
            {
                var x = Random.Next<uint>();
                Bits.unpack32x1(x, y1);
                Bits.unpack32x1(x, y2);
                Claim.eq(y1.ToBitString(), y2.ToBitString());
            }            
        }    
    }
}