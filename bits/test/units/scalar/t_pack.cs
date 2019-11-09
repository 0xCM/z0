//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    public class t_pack : ScalarBitTest<t_pack>
    {
        public void pack_1x8()
        {
            pack1xN_check<byte>();
        }

        public void pack_1x16()
        {
            pack1xN_check<ushort>();
        }

        public void pack_1x32()
        {
            pack1xN_check<uint>();
        }

        public void pack_1x64()
        {
            pack1xN_check<ulong>();
        }

        public void pack_2x16()
        {
            var src = Random.Span<ushort>(SampleSize);
            foreach(var x in src)
            {
                Bits.split(x,out var x0, out var x1);
                var y = Bits.pack(x0, x1);
                Claim.eq(x,y);
                Claim.eq(x, BitConverter.ToUInt16(new byte[]{x0, x1}));
            }
        }

        public void pack_4x32()
        {
            var src = Random.Span<uint>(SampleSize);
            foreach(var x in src)
            {
                Bits.split(x, out var x0, out var x1, out var x2, out var x3);
                var y = Bits.pack(x0, x1, x2, x3);
                Claim.eq(x,y);
                Claim.eq(x, BitConverter.ToUInt32(new byte[]{x0, x1, x2, x3}));
            }

            {
                var xval = 0b10100111001110001110010110101000;
                var x0 = (byte)0b10101000;
                var x1 = (byte)0b11100101;
                var x2 = (byte)0b00111000;
                var x3 = (byte)0b10100111;
                Claim.eq(xval, Bits.pack(x0, x1, x2,x3));

                var bsExpect = "10100111001110001110010110101000";
                var bsActual = xval.ToBitString().Format();
                Claim.eq(bsExpect, bsActual);

                var bsAssembly = BitString.Assemble("10101000", "11100101", "00111000","10100111").Format();
                Claim.eq(bsExpect, bsAssembly);
            }
        }

        public void pack_8x64()
        {
            var src = Random.Span<ulong>(SampleSize);
            foreach(var x in src)
            {
                Bits.split(x, out var x0, out var x1, out var x2, out var x3, out var x4, out var x5, out var x6, out var x7);
                var y = Bits.pack(x0, x1, x2, x3, x4, x5, x6, x7);
                Claim.eq(x,y);
                Claim.eq(x, BitConverter.ToUInt64(new byte[]{x0, x1, x2, x3, x4, x5, x6, x7}));
            }
        }

        public void pack_reversed()
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

        public void pack_bistring()
        {
            var x =  0b111010010110011010111001110000100001101ul;
            var xbs = BitString.Parse("111010010110011010111001110000100001101");
            var packed = xbs.Pack(0, 8);
            var joined = packed.TakeUInt64();
            Claim.Equals(x,joined);
        }

        public void pack_roundtrip()
        {            
            pack_roundtrip_check<uint>(43);
            pack_roundtrip_check<ushort>(73);
            pack_roundtrip_check<ulong>(128);
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
                    Claim.yea(gbits.match(dst, j++, x0, pos));
                    Claim.yea(gbits.match(dst, j++, x1, pos));
                    Claim.yea(gbits.match(dst, j++, x2, pos));
                    Claim.yea(gbits.match(dst, j++, x3, pos));
                    Claim.yea(gbits.match(dst, j++, x4, pos));
                    Claim.yea(gbits.match(dst, j++, x5, pos));
                    Claim.yea(gbits.match(dst, j++, x6, pos));
                    Claim.yea(gbits.match(dst, j++, x7, pos));                    
                }
            }
        }

        public static ref byte pack(byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7, byte pos, ref byte dst)
        {
          if(BitMask.test(x0, pos)) 
            BitMask.enable(ref dst, 0);
          if(BitMask.test(x1, pos)) 
            BitMask.enable(ref dst, 1);
          if(BitMask.test(x2, pos)) 
            BitMask.enable(ref dst, 2);
          if(BitMask.test(x3, pos)) 
            BitMask.enable(ref dst, 3);
          if(BitMask.test(x4, pos)) 
            BitMask.enable(ref dst, 4);
          if(BitMask.test(x5, pos)) 
            BitMask.enable(ref dst, 5);
          if(BitMask.test(x6, pos)) 
            BitMask.enable(ref dst, 6);
          if(BitMask.test(x7, pos)) 
            BitMask.enable(ref dst, 7);
          return ref dst;
        }

        public void pack_span32u()
        {
            var x0 = BitVector32.FromScalar(0b00001010110000101001001111011001u);
            var x1 = BitVector32.FromScalar(0b00001010110110101001001111000001u);
            var src = Random.Span<byte>(Pow2.T04).ReadOnly();
            var packed = span<uint>(src.Length / 4);
            gbits.pack(src, packed);

            for(var i = 0; i<packed.Length; i++)
            {
                 var x = BitVector32.FromScalar(BitConverter.ToUInt32(src.Slice(4*i)));
                 var y = BitVector32.FromScalar(packed[i]);
                Claim.eq((uint)x, (uint)y, AppMsg.Error($"{x.ToBitString()} != {y.ToBitString()}"));
            }        
        }

        public void pack_span64u()
        {
            var x0 = BitVector32.FromScalar(0b00001010110000101001001111011001u);
            var x1 = BitVector32.FromScalar(0b00001010110110101001001111000001u);
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

        public void pack_split_u16()
        {
            var len = Pow2.T08;
            var lhs = Random.Array<byte>(len);
            var rhs = Random.Array<byte>(len);
            for(var i=0; i<len; i++)
            {
                var dst = Bits.pack(lhs[i], rhs[i]);
                Bits.split(dst,out var x0, out var x1);
                
                Claim.eq(x0, lhs[i]);
                Claim.eq(x1, rhs[i]);

            }        
        }

        public void unpack_8x1_check()
        {
            for(var i=0; i<= 255; i++)            
            {
                byte b = (byte)i;
                var x = BitStore.bitseq(b);
                var y = BitStore.select(b);
                Claim.eq(x,y);

                var up1 = BitStore.select((byte)i);
                Span<byte> up2 = stackalloc byte[8];
                BitParts.unpack8x1(b, up2);
                Claim.eq(BitString.FromBitSeq(up1), BitString.FromBitSeq(up2));
            }
        }

        public void unpack_64x1_check()
        {
            Span<byte> dst = stackalloc byte[64];

            for(var i=0; i< SampleSize; i++)
            {
                var src = Random.Next<ulong>();
                BitParts.unpack64x1(src, dst);
                var bitsPC = dst.PopCount();
                var bytes = ByteSpan.From(ref src);
                var bytesPC = bytes.PopCount();
                Claim.eq(bitsPC, bytesPC);        
            }
        }

        public void unpack_32x1_check()
        {

            Span<byte> y1 = stackalloc byte[32];
            Span<byte> y2 = stackalloc byte[32];
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.Next<uint>();
                BitParts.unpack32x1(x, y1);
                BitParts.unpack32x1(x, y2);
                Claim.eq(y1.ToBitString(), y2.ToBitString());
            }            
        }    
    

        /// <summary>
        /// Packs bits into bytes
        /// </summary>
        /// <param name="src">The source values</param>
        /// <remarks>Adapted from https://stackoverflow.com/questions/713057/convert-bool-to-byte</remarks>
        static Span<byte> pack(ReadOnlySpan<bit> src, Span<byte> dst)
        {
            int srcLen = src.Length;
            for (int i = 0; i < srcLen; i++)
                if (src[i])
                    dst[i >> 3] |= (byte)((byte)1 << (i & 0x07));
            return dst;
        }

        static Span<byte> pack(ReadOnlySpan<bit> src)
        {
            int srcLen = src.Length;
            int dstLen = srcLen >> 3;
            
            if ((srcLen & 0x07) != 0) 
                ++dstLen;

            return pack(src, new byte[dstLen]);            
        }

        void pack_roundtrip_check<T>(BitSize bitcount)
            where T : unmanaged
        {
            var src = Random.BitString(bitcount);
            Claim.eq(bitcount, src.Length);

            var x = src.ToBitSpan();
            Claim.eq(bitcount, x.Length);
            
            var y = pack(x);
            var sizeT = size<T>();
            
            var q = Math.DivRem(bitcount, 8, out int r);
            var bytes = q + (r == 0 ? 0 : 1);
            Claim.eq(bytes, y.Length);

            var bulk = ByteSpan.Cast<T>(y,out Span<byte> rem);

            var merged = rem.Length != 0 ? bulk.Extend(bulk.Length + 1) : bulk;
            if(merged.Length != bulk.Length)
                merged[merged.Length - 1] = rem.TakeScalar<T>();

            var bsOutput = merged.ToBitString().Truncate(bitcount);
            Claim.eq(src, bsOutput);
            Claim.eq((src & ~bsOutput).PopCount(),0);    

        }

        /// <summary>
        /// Verifies the correct operation of the generic pack function
        /// that compresses sizeof(T)*8 bits into a single T value
        /// </summary>
        /// <param name="cycles">The number of times the test is repeated</param>
        /// <typeparam name="T">The primal type</typeparam>
        void pack1xN_check<T>()
            where T : unmanaged
        {
            Span<byte> _dst = new byte[bitsize<T>()];

            for(var cycle=0; cycle<SampleSize; cycle++)
            {
                var src = Random.Next<T>();
                var unpacked = gbits.unpack(src, _dst);
                for(var j = 0; j<unpacked.Length; j++)
                    Claim.eq((Bit)gbits.test(src, j), (Bit)unpacked[j]);
                
                var dst = default(T);
                gbits.pack(unpacked, ref dst);
                Claim.eq(src, dst);
            }
        }

    }
}