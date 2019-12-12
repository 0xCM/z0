//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public class t_sb_pack : t_sb<t_sb_pack>
    {
        public void sb_pack_bits_64x1_basecase()
        {
            var src = ulong.MaxValue;
            Span<bit> dst = new bit[64];
            Bits.part64x1(src,dst);
            for(var i=0; i< dst.Length; i++)
                Claim.yea(dst[i]);
        }

        public void sb_pack_8x1_basecase()
        {
            void case1()
            {
                var src = DataBlocks.single<byte>(n256);
                vbuild.ones<byte>(n256).StoreTo(src);
                var dst = Bits.pack8x1(src);
                Claim.eq(dst,uint.MaxValue);

            }

            void case2()
            {
                var src = DataBlocks.single<byte>(n128);
                vbuild.ones<byte>(n128).StoreTo(src);
                var dst = Bits.pack8x1(src);
                Claim.eq(dst,ushort.MaxValue);
            }

            RunLocals();
        }

        public void sb_pack_8x1_32()
        {
            var count = n4;
            var block = n32;
            for(var sample = 0; sample < SampleSize; sample++)
            {
                var bs = Random.BitString(count);
                var bitseq = bs.BitSeq.Blocked(block);
                var packed = Bits.pack8x1(bitseq);
                Claim.eq(bs.TakeScalar<byte>(), packed);
            }
        }

        public void sb_pack_8x1_64()
        {
            var count = n8;
            var block = n64;
            for(var sample = 0; sample < SampleSize; sample++)
            {
                var bs = Random.BitString(count);
                var bitseq = bs.BitSeq.Blocked(block);
                var packed = Bits.pack8x1(bitseq);
                Claim.eq(bs.TakeScalar<byte>(), packed);
            }
        }

        public void sb_pack_8x1_128()
        {
            var count = n16;
            var block = n128;
            for(var sample = 0; sample < SampleSize; sample++)
            {
                var bs = Random.BitString(count);
                var bitseq = bs.BitSeq.Blocked(block);
                uint packed = Bits.pack8x1(bitseq);
                for(var i=0; i< count; i++)
                    Claim.eq(bs[i], BitMask.testbit(packed, i));

            }
        }

        public void sb_pack_8x1_256()
        {
            var count = n32;
            var block = n256;
            for(var sample = 0; sample < SampleSize; sample++)
            {
                var bs = Random.BitString(count);
                var bitseq = bs.BitSeq.Blocked(block);
                uint packed = Bits.pack8x1(bitseq);
                for(var i=0; i< count; i++)
                    Claim.eq(bs[i], BitMask.testbit(packed, i));

            }
        }

        public void sb_pack_basecase()
        {
            var x = 0b10100111001110001110010110101000;
            var x0 = (byte)0b10101000;
            var x1 = (byte)0b11100101;
            var x2 = (byte)0b00111000;
            var x3 = (byte)0b10100111;
            Claim.eq(x, Bits.concat(x0, x1, x2,x3));

            var bsExpect = "10100111001110001110010110101000";
            var bsActual = x.ToBitString().Format();
            Claim.eq(bsExpect, bsActual);

            var bsAssembly = BitString.assemble("10101000", "11100101", "00111000","10100111").Format();
            Claim.eq(bsExpect, bsAssembly);

            var a =  0b111010010110011010111001110000100001101ul;
            var abs = BitString.parse("111010010110011010111001110000100001101");
            var abs_packed = abs.Pack(0, 8);
            var abs_joined = abs_packed.TakeUInt64();
            Claim.Equals(a,abs_joined);
        }

        public void sb_pack_1x8()
            => sb_pack_1xN_check<byte>();

        public void sb_pack_1x16()
            => sb_pack_1xN_check<ushort>();

        public void sb_pack_1x32()
            => sb_pack_1xN_check<uint>();

        public void sb_pack_1x64()
            => sb_pack_1xN_check<ulong>();

        public void sb_pack_2x16()
        {
            var src = Random.Span<ushort>(SampleSize);
            foreach(var x in src)
            {
                Bits.split(x,out var x0, out var x1);
                var y = Bits.concat(x0, x1);
                Claim.eq(x,y);
                Claim.eq(x, BitConvert.ToUInt16(new byte[]{x0, x1}));
            }
        }

        public void sb_pack_4x32()
        {
            var src = Random.Span<uint>(SampleSize);
            foreach(var x in src)
            {
                Bits.split(x, out var x0, out var x1, out var x2, out var x3);
                var y = Bits.concat(x0, x1, x2, x3);
                Claim.eq(x,y);
                Claim.eq(x, BitConvert.ToUInt32(new byte[]{x0, x1, x2, x3}));
            }

        }

        public void sb_pack_8x64()
        {
            var src = Random.Span<ulong>(SampleSize);
            foreach(var x in src)
            {
                Bits.split(x, out var x0, out var x1, out var x2, out var x3, out var x4, out var x5, out var x6, out var x7);
                var y = Bits.concat(x0, x1, x2, x3, x4, x5, x6, x7);
                Claim.eq(x,y);
                Claim.eq(x, BitConverter.ToUInt64(new byte[]{x0, x1, x2, x3, x4, x5, x6, x7}));
            }
        }

        public void sb_pack_reversed()
        {
            var x0 = Random.Next<byte>();
            var y0 = x0.ToBitString().Reverse().Pack().First();
            var z0 = Bits.rev(x0);
            Claim.eq(y0,z0);

            var x1 = Random.Next<ushort>();
            var y1 = x1.ToBitString().Reverse().Pack().TakeUInt16();
            var z1 = Bits.rev(x1);
            Claim.eq(y1,z1);

            var x2 = Random.Next<uint>();
            var y2 = x2.ToBitString().Reverse().Pack().TakeUInt32();
            var z2 = Bits.rev(x2);
            Claim.eq(y2,z2);

            var x3 = Random.Next<ulong>();
            var y3 = x3.ToBitString().Reverse().Pack().TakeUInt64();
            var z3 = Bits.rev(x3);
            Claim.eq(y3,z3);
        }

        public void pack_roundtrip()
        {            
            gsb_pack_check<uint>(43);
            gsb_pack_check<ushort>(73);
            gsb_pack_check<ulong>(128);
        }

        public void pack_splits()
        {
            var src = Random.Span<ulong>(Pow2.T11);
            foreach(var x in src)
            {
                Bits.split(x, out var x0, out var x1, out var x2, out var x3, out var x4, out var x5, out var x6, out var x7);

                for(var i=0; i<8; i++)
                {
                    var dst = (byte)0;
                    var pos = (byte)(Pow2.pow(i) - 1);
                    pack(x0, x1, x2, x3, x4, x5, x6, x7, pos, ref dst);
                    
                    var j = 0;
                    Claim.yea(gbits.bitmatch(dst, j++, x0, pos));
                    Claim.yea(gbits.bitmatch(dst, j++, x1, pos));
                    Claim.yea(gbits.bitmatch(dst, j++, x2, pos));
                    Claim.yea(gbits.bitmatch(dst, j++, x3, pos));
                    Claim.yea(gbits.bitmatch(dst, j++, x4, pos));
                    Claim.yea(gbits.bitmatch(dst, j++, x5, pos));
                    Claim.yea(gbits.bitmatch(dst, j++, x6, pos));
                    Claim.yea(gbits.bitmatch(dst, j++, x7, pos));                    
                }
            }
        }

        public static ref byte pack(byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7, byte pos, ref byte dst)
        {
          if(BitMask.testbit(x0, pos)) 
            dst = BitMask.enable(dst, 0);
          if(BitMask.testbit(x1, pos)) 
            dst = BitMask.enable(dst, 1);
          if(BitMask.testbit(x2, pos)) 
            dst = BitMask.enable(dst, 2);
          if(BitMask.testbit(x3, pos)) 
            dst = BitMask.enable(dst, 3);
          if(BitMask.testbit(x4, pos)) 
            dst = BitMask.enable(dst, 4);
          if(BitMask.testbit(x5, pos)) 
            dst = BitMask.enable(dst, 5);
          if(BitMask.testbit(x6, pos)) 
            dst = BitMask.enable(dst, 6);
          if(BitMask.testbit(x7, pos)) 
            dst = BitMask.enable(dst, 7);
          return ref dst;
        }

        public void sb_pack_span_32()
        {
            var x0 = BitVector.from(n32,0b00001010110000101001001111011001u);
            var x1 = BitVector.from(n32,0b00001010110110101001001111000001u);
            var src = Random.Span<byte>(Pow2.T04).ReadOnly();
            var packed = span<uint>(src.Length / 4);
            gbits.pack(src, packed);

            for(var i = 0; i<packed.Length; i++)
            {
                 var x = BitVector.from(n32,BitConverter.ToUInt32(src.Slice(4*i)));
                 var y = BitVector.from(n32,packed[i]);
                Claim.eq((uint)x, (uint)y, AppMsg.Error($"{x.ToBitString()} != {y.ToBitString()}"));
            }        
        }

        public void sb_pack_span_64()
        {
            var x0 = BitVector.from(n32,0b00001010110000101001001111011001u);
            var x1 = BitVector.from(n32,0b00001010110110101001001111000001u);
            var src = Random.Span<byte>(Pow2.T04).ReadOnly();
            var packed = span<ulong>(src.Length / 8);
            gbits.pack(src, packed);

            for(var i = 0; i<packed.Length; i++)
            {
                 var x = BitVector.from(n64, BitConverter.ToUInt64(src.Slice(8*i)));
                 var y = BitVector.from(n64, packed[i]);
                Claim.eq((ulong)x, (ulong)y, AppMsg.Error($"{x.ToBitString()} != {y.ToBitString()}"));
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

        public void sb_unpack_8x1()
        {
            for(var i=0; i<= 255; i++)            
            {
                byte b = (byte)i;
                var x = BitStore.bitseq(b);
                var y = BitStore.select(b);
                Claim.eq(x,y);

                var up1 = BitStore.select((byte)i);
                Span<byte> up2 = stackalloc byte[8];
                Bits.unpack8x1(b, up2);
                Claim.eq(BitString.load(up1), BitString.load(up2));
            }
        }

        public void sb_unpack_64x1()
        {
            Span<byte> dst = stackalloc byte[64];

            for(var i=0; i< SampleSize; i++)
            {
                var src = Random.Next<ulong>();
                Bits.unpack64x1(src, dst);
                var bitsPC = dst.PopCount();
                var bytes = BitConvert.GetBytes(src);
                var bytesPC = bytes.PopCount();
                Claim.eq(bitsPC, bytesPC);        
            }
        }

        public void sb_unpack_32x1()
        {
            Span<byte> y1 = stackalloc byte[32];
            Span<byte> y2 = stackalloc byte[32];
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.Next<uint>();
                Bits.unpack32x1(x, y1);
                Bits.unpack32x1(x, y2);
                Claim.eq(y1.ToBitString(), y2.ToBitString());
            }            
        }    
    }
}