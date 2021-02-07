//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class t_split : t_bitcore<t_split>
    {

        public void sb_split_16x8()
        {
            var src = Random.Span<ushort>(RepCount);
            foreach(var x in src)
            {
                Bits.split(x,out var x0, out var x1);
                var y = Bits.concat(x0, x1);
                Claim.eq(x,y);
                Claim.eq(x, z.u16(new byte[]{x0, x1}));
            }
        }

        public void sb_split_32x8()
        {
            var src = Random.Span<uint>(RepCount);
            foreach(var x in src)
            {
                Bits.split(x, out var x0, out var x1, out var x2, out var x3);
                var y = Bits.concat(x0, x1, x2, x3);
                Claim.eq(x,y);
                Claim.eq(x, z.u32(new byte[]{x0, x1, x2, x3}));
            }
        }

        public void sb_split_64x8()
        {
            static ref byte pack(byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7, byte pos, ref byte dst)
            {
                if(bit.test(x0, pos))
                    dst = Bits.enable(dst, 0);
                if(bit.test(x1, pos))
                    dst = Bits.enable(dst, 1);
                if(bit.test(x2, pos))
                    dst = Bits.enable(dst, 2);
                if(bit.test(x3, pos))
                    dst = Bits.enable(dst, 3);
                if(bit.test(x4, pos))
                    dst = Bits.enable(dst, 4);
                if(bit.test(x5, pos))
                    dst = Bits.enable(dst, 5);
                if(bit.test(x6, pos))
                    dst = Bits.enable(dst, 6);
                if(bit.test(x7, pos))
                    dst = Bits.enable(dst, 7);
                return ref dst;
            }

            var src = Random.Span<ulong>(Pow2.T11);
            foreach(var x in src)
            {
                Bits.split(x, out var x0, out var x1, out var x2, out var x3, out var x4, out var x5, out var x6, out var x7);
                var y = Bits.concat(x0, x1, x2, x3, x4, x5, x6, x7);
                Claim.eq(x,y);
                Claim.eq(x, BitConverter.ToUInt64(new byte[]{x0, x1, x2, x3, x4, x5, x6, x7}));

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

                Claim.eq(x0, lhs[i]);
                Claim.eq(x1, rhs[i]);
            }
        }


        public void sb_unpack_64x1()
        {
            Span<byte> dst = stackalloc byte[64];

            for(var i=0; i< RepCount; i++)
            {
                var src = Random.Next<ulong>();
                Bits.unpack1x8x64(src, dst);
                var bitsPC = dst.PopCount();
                var bytes = z.bytes(src);
                var bytesPC = bytes.PopCount();
                Claim.eq(bitsPC, bytesPC);
            }
        }

        public void sb_unpack_32x1()
        {
            Span<byte> y1 = stackalloc byte[32];
            Span<byte> y2 = stackalloc byte[32];
            for(var i=0; i< RepCount; i++)
            {
                var x = Random.Next<uint>();
                Bits.unpack1x8x32(x, y1);
                Bits.unpack1x8x32(x, y2);
                Claim.eq(y1.ToBitString(), y2.ToBitString());
            }
        }
    }
}