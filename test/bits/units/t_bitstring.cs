//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public class t_bitstring : t_bitcore<t_bitstring>
    {
        void bs_bitview()
        {
            var x = Random.CpuVector<int>(n128);
            var y = Bit.editor(x);
            var ys = y.Bytes.ToBitString();
            var xs = x.ToBitString();
            Claim.eq(ys,xs);
        }

        public void bs_seq_8u()
            => bs_seq_check<byte>();

        public void bs_seq_16u()
            => bs_seq_check<ushort>();

        public void bs_seq_32u()
            => bs_seq_check<uint>();

        public void bs_seq_64u()
            => bs_seq_check<ulong>();

        public void bs_fromscalar_8u()
            => bs_fromscalar_check<byte>();

        public void bs_fromscalar_8i()
            => bs_fromscalar_check<sbyte>();

        public void bs_fromscalar_16i()
            => bs_fromscalar_check<short>();

        public void bs_fromscalar_16u()
            => bs_fromscalar_check<ushort>();

        public void bs_fromscalar_32i()
            => bs_fromscalar_check<int>();

        public void bs_fromscalar_32u()
            => bs_fromscalar_check<uint>();

        public void bs_fromscalar_64u()
            => bs_fromscalar_check<ulong>();

        public void bs_fromscalar_64i()
            => bs_fromscalar_check<long>();

        public void bs_convert_8u()
            => bs_convert_check<byte>();

        public void bs_convert_16u()
            => bs_convert_check<ushort>();

        public void bs_convert_32u()
            => bs_convert_check<uint>();

        public void bs_convert_64u()
            => bs_convert_check<ulong>();

        public void bs_rep_8u()
            => bs_rep_check<byte>();

        public void bs_rep_16u()
            => bs_rep_check<ushort>();

        public void bs_rep_32u()
            => bs_rep_check<uint>();

        public void bs_rep_64u()
            => bs_rep_check<ulong>();

        public void bs_parse_range()
        {
            bs_parse_range_check(13, 61);
            bs_parse_range_check(2, 9);

        }

        public void bs_parse_8u()
            => bs_parse_check<byte>();

        public void bs_parse_8i()
            => bs_parse_check<sbyte>();

        public void bs_parse_16i()
            => bs_parse_check<short>();

        public void bs_parse_16u()
            => bs_parse_check<ushort>();

        public void bs_parse()
        {
            bs_parse_check<uint>();
            bs_parse_check<int>();
            bs_parse_check<ulong>();
            bs_parse_check<long>();
        }

        public void bs_pow2()
        {
            for(var i=0; i<=231; i++)
            {
                var bs = BitString.pow2(i);
                Claim.eq((int)bs.Length, i + 1);
                for(var j=0; j<bs.Length; j++)
                {
                    if(j != bs.Length - 1)
                        Claim.eq(bs[j], Bit32.Off);
                    else
                        Claim.eq(bs[j], Bit32.On);
                }

                if(i <= 63)
                {
                    var val1 = Pow2.pow((byte)i);
                    var val2 = bs.TakeScalar<ulong>();
                    Claim.eq(val1,val2);
                }
            }
        }

        public void bs_to_u8()
        {
            var x = (byte)0b10110110;
            var y = x.ToBitString();
            Claim.eq("10110110".ToBitString(), y);
            Claim.eq(5, y.PopCount());

            var z = y.Pack();
            Claim.eq(1,z.Length);
            Claim.eq(x, z[0]);
        }

        public void bs_nlz()
        {
            var src = Random.BitStrings(5, 60).Take(Pow2.T14);
            foreach(var bs in src)
            {
                var bvX = bs.TakeScalar<ulong>().ToBitString();
                var nlzX = bvX.PopCount();
                var bv = bs.ToBitVector(n64);
                var nlzY = BitVector.pop(bv);
                Claim.eq(nlzX, nlzY);
            }
        }

        public void bs_seq()
        {
            var srcA = Random.Stream<uint>().Take(RepCount);
            var srcB = Random.Stream<uint>().Take(RepCount);
            var pairs = srcA.Zip(srcB);

            foreach(var aVal in srcA)
                Claim.eq(aVal.ToBitString(), aVal.ToBitString());

            foreach(var pair in pairs)
                Claim.neq(pair.First.ToBitString(), pair.Second.ToBitString());
        }

        public void bs_truncate()
        {
            for(var i=0; i<RepCount; i++)
            {
                var src = Random.BitString(RepCount);
                Claim.eq(src.Length, RepCount);

                var len = Random.Next<int>(2, RepCount - 2);
                var dst = src.Truncate(len);
                Claim.eq(len, dst.Length);
                for(var j=0; j<len; j++)
                    Claim.eq(src[j], dst[j]);
            }
        }

        // public void bs_wordgen()
        // {
        //     var wordLen = 8;
        //     var wordCount = Pow2.pow(wordLen);
        //     var words = BinaryLanguage.Get().Words(wordLen).ToArray();
        //     Claim.almost(wordCount, words.Length);

        //     iter(words, w => Claim.eq(wordLen, w.Format().Length));

        //     for(var i=0u; i<wordCount; i++)
        //     {
        //         var w = words[i];
        //         var value = w.TakeScalar<byte>();
        //         Numeric.eq(i, value);
        //     }
        // }

        public void bs_partition()
        {
            var src = "0000010100001100101010001";
            var bs = BitString.parse(src);
            Claim.eq(bs.Length, 25);

            var b1 = bs.Partition(1);
            Claim.eq(src.Length, b1.Length);

            var b5 = bs.Partition(5);
            Claim.eq(5,b5.Length);

            var b3 = bs.Partition(3);
            Claim.eq(9,b3.Length);
        }

        public void bs_patterns()
        {
            var p1 = (byte)0b11001110;
            var s1 = BitString.replicate(p1, 4);
            Claim.eq(s1.Length,32);
            Claim.eq(p1.ToBitString(), s1[8..15]);

            var p2 = (ushort)0b1111111100010001;
            var s2 = BitString.replicate(p2, 2);
            Claim.eq(s2.Length,32);
            Claim.eq(p2.ToBitString(), s2[0..15]);
        }

        public void bs_tlz()
        {
            ClaimPrimalSeq.ClaimEq("100", BitString.scalar(0b00000100).Format(true));
            ClaimPrimalSeq.ClaimEq("101", BitString.scalar(0b00000101).Format(true));
            ClaimPrimalSeq.ClaimEq("1000101", BitString.scalar(0b01000101).Format(true));
            ClaimPrimalSeq.ClaimEq("11010101", BitString.scalar(0b11010101).Format(true));
        }

        public void bs_parselit()
        {
            var a = BitString.parse("01010111");
            var b = a.TakeScalar<byte>();
            Claim.eq((byte)0b01010111, b);

            var x =  0b111010010110011010111001110000100001101ul;
            var xbs = BitString.parse("111010010110011010111001110000100001101");
            var ybs = x.ToBitString();
            Claim.yea(xbs == ybs);

            var y = xbs.TakeScalar<ulong>();
            Claim.eq(x, y);

            var z = ybs.TakeScalar<ulong>();
            Claim.eq(x, z);


            var byx = BitConverter.GetBytes(x).ToSpan();
            var byy = ByteWrite.write(x);
            ClaimNumeric.eq(byx,byy);
        }

        public void bs_assemble()
        {
            var src = Random.Span<ulong>(Pow2.T08);

            foreach(var x in src)
            {
                var bsX = x.ToBitString();
                Claim.eq(64, bsX.Length);
                var blocks = bsX.Partition(8);
                Claim.eq(8, blocks.Length);

                var bsY = BitString.assemble(blocks.Select(x => x.Format()).ToArray());
                Claim.eq(bsX, bsY);

                var bytes = sys.alloc<byte>(8);
                for(var i=0; i<8; i++)
                    bytes[i] = blocks[i].TakeScalar<byte>();

                var j = 0;
                var y = Bits.concat(bytes[j++], bytes[j++], bytes[j++], bytes[j++],
                    bytes[j++], bytes[j++], bytes[j++], bytes[j++]);
                Claim.eq(x,y);
            }
        }

        void bs_seq_check<T>()
            where T : unmanaged
        {

            void case2()
            {
                var src = Random.Span<T>(RepCount);
                for(var i=0; i<src.Length; i++)
                {
                    var x0 = src[i];
                    var x1 = BitStore.storeseq(x0);
                    var seqlen = x1.Length;
                    Claim.eq(seqlen, bitwidth<T>());

                    for(byte j = 0; j < seqlen; j++)
                        Claim.eq(gbits.testbit32(x0, j), (Bit32)(x1[j] == 1));
                }

            }

            case2();

        }

        void bs_convert_check<T>()
            where T : unmanaged
        {
            var src = Random.Span<T>(RepCount);
            foreach(var x in src)
            {
                var y = BitString.scalar(x);
                var z = y.TakeScalar<T>();
                Claim.eq(x,z);
            }
        }

        void bs_parse_check<T>()
            where T : unmanaged
        {
            var src = Random.Span<T>(RepCount);
            for(var i=0; i<src.Length; i++)
            {
                var x = BitString.bitchars(src[i]);
                gbits.parse(x, 0, out T y);
                Claim.eq(src[i], y);
            }
        }

        void bs_parse_range_check(int minlen, int maxlen)
        {
            for(var cycle=0; cycle< CycleCount; cycle++)
            {
                var x = Random.BitString(minlen, maxlen);
                var y = BitString.parse(x).Format();
                var z = BitString.parse(y);

                Claim.eq(x.Length, y.Length);
                Claim.eq(z.Length, y.Length);
                for(var i=0; i< x.Length; i++)
                    Claim.eq(x[i], z[i]);

                Claim.Require(x.Equals(z));
                Claim.eq(x,z);
            }
        }

        void bs_rep_check<T>()
            where T : unmanaged
        {
            var src = Random.Span<T>(RepCount);
            for(var i=0; i<src.Length; i++)
            {
                var x = src[i];
                var bs = BitString.scalar(src[i]);
                var y = bs.TakeScalar<T>();
                Claim.eq(x,y);
                ClaimPrimalSeq.ClaimEq(bs.Format(), BitString.scalar(y).Format());
            }
        }

        void bs_fromscalar_check<T>(T t = default)
            where T : unmanaged
        {
            var src = Random.Span<T>(RepCount);
            for(var i=0; i<src.Length; i++)
            {
                var bc1 =  BitString.scalar(src[i]).Format();
                var bc3 = BitString.scalar(src[i]);
                ClaimPrimalSeq.eq(bc1,bc3);
            }
        }
    }
}