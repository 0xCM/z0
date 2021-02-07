//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public class t_bitfields : t_bitcore<t_bitfields>
    {
        enum BF_A : byte
        {
            F08_0 = 0,

            F08_1 = 1,

            F08_2 = 2,

            F08_3 = 3
        }

        public void bitfield_a()
        {
            var spec = BitFieldModels.specify(
                BitFieldModels.segment(BF_A.F08_0, 0, 1),
                BitFieldModels.segment(BF_A.F08_1, 2, 3),
                BitFieldModels.segment(BF_A.F08_2, 4, 5),
                BitFieldModels.segment(BF_A.F08_3, 6, 7)
                );


            Claim.eq((byte)4, spec.FieldCount);
            Claim.eq((byte)0, spec[0].StartPos);
            Claim.eq((byte)2, spec[1].StartPos);
            Claim.eq((byte)4, spec[2].StartPos);
            Claim.eq((byte)6, spec[3].StartPos);
            Claim.eq((byte)2, spec[0].Width);
            Claim.eq((byte)2, spec[1].Width);
            Claim.eq((byte)2, spec[2].Width);
            Claim.eq((byte)2, spec[3].Width);

            var bf = new BitField<byte>(spec);
            for(var rep=0; rep<RepCount; rep++)
            {
                var input = Random.Next<byte>();

                var seg0 = bf.Extract(spec[0], input);
                var seg1 = bf.Extract(spec[1], input);
                var seg2 = bf.Extract(spec[2], input);
                var seg3 = bf.Extract(spec[3], input);

                Claim.eq(Bits.bitslice(input, 0, 2), seg0);
                Claim.eq(Bits.bitslice(input, 2, 2), seg1);
                Claim.eq(Bits.bitslice(input, 4, 2), seg2);
                Claim.eq(Bits.bitslice(input, 6, 2), seg3);

                var output =  gmath.or(
                    gmath.sll(seg0, (byte)spec[0].StartPos),
                    gmath.sll(seg1, (byte)spec[1].StartPos),
                    gmath.sll(seg2, (byte)spec[2].StartPos),
                    gmath.sll(seg3, (byte)spec[3].StartPos));
                Claim.eq(input,output);
            }
        }

        enum BFB_I : byte
        {
            BFB_0 = 0,

            BFB_1 = 1,

            BFB_2 = 2,

            BFB_3 = 3,
        }


        public void bitfield_b()
        {
            var spec = BitFieldModels.specify(
                BitFieldModels.segment(BFB_I.BFB_0, 0, 3),
                BitFieldModels.segment(BFB_I.BFB_1, 4, 7),
                BitFieldModels.segment(BFB_I.BFB_2, 8, 9),
                BitFieldModels.segment(BFB_I.BFB_3, 10, 15)
                );
            var dst = memory.alloc<ushort>(spec.FieldCount);
            var bf = BitFields.create<ushort>(spec);

            Claim.eq((byte)4,spec.FieldCount);

            for(var rep=0; rep<RepCount; rep++)
            {
                var src = Random.Next<ushort>();
                dst.Clear();
                bf.Deposit(src,dst);

                var output =  gmath.or(
                    gmath.sll(dst[0], (byte)spec[0].StartPos),
                    gmath.sll(dst[1], (byte)spec[1].StartPos),
                    gmath.sll(dst[2], (byte)spec[2].StartPos),
                    gmath.sll(dst[3], (byte)spec[3].StartPos)
                );

                Claim.eq(src,output);
            }
        }

        enum BFC_I : byte
        {
            BFC_0 = 0,

            BFC_1 = 1,

            BFC_2 = 2,

            BFC_3 = 3,
        }

        enum BFC_W : byte
        {
            BFCW_0 = 4,

            BFCW_1 = 4,

            BFCW_2 = 2,

            BFCW_3 = 6,
        }

        public void bitfield_c()
        {
            var spec = BitFieldModels.specify<BFC_I,BFC_W>();
            var bf = BitFields.create<byte>(spec);
            var dst = alloc<byte>(spec.FieldCount);

            Claim.eq((byte)4, spec.FieldCount);

            for(var rep=0; rep<RepCount; rep++)
            {
                var src = Random.Next<byte>();

                dst.Clear();
                bf.Deposit(src, dst);

                var result1 =  gmath.or(
                    gmath.sll(dst[0], (byte)spec[0].StartPos),
                    gmath.sll(dst[1], (byte)spec[1].StartPos),
                    gmath.sll(dst[2], (byte)spec[2].StartPos),
                    gmath.sll(dst[3], (byte)spec[3].StartPos)
                    );

                var result2 = gmath.or(
                    bf.Offset(spec[0], src),
                    bf.Offset(spec[1], src),
                    bf.Offset(spec[2], src),
                    bf.Offset(spec[3], src)
                    );

                Claim.eq(src,result1);
                Claim.eq(src,result2);
            }
        }

        //[F1(0):0..7, F2(1):8..11, F3(2):12..13, F4(3):14..15, F5(4):16..18, F6(5):19..21, F7(6):22..26, F8(7):27..31, F9(8):32..40]
        enum BFD_W : byte
        {
            F0_Width = 8,

            F1_Width = 4,

            F2_Width = 2,

            F3_Width = 2,

            F4_Width = 3,

            F5_Width = 3,

            F6_Width = 5,

            F7_Width = 5,

            F8_Width = 9
        }

        enum BFD_I : byte
        {
            F0 = 0,

            F1 = 1,

            F2 = 2,

            F3 = 3,

            F4 = 4,

            F5 = 5,

            F6 = 6,

            F7 = 7,

            F8 = 8
        }

        [MethodImpl(Inline)]
        public static T or<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            var result = default(T);
            for(var i=0; i<src.Length; i++)
                result = MSvc.or<T>().Invoke(result, z.skip(src,(uint)i));
            return result;
        }

        public void bitfield_d()
        {
            var spec = BitFieldModels.specify<BFD_I,BFD_W>();
            var bf = BitFields.create<ulong>(spec);
            var dst = span(alloc<ulong>(spec.FieldCount));
            var tmp = span(alloc<ulong>(spec.FieldCount));
            var positions = spec.Segments.Map(s => (byte)s.StartPos);

            Trace(spec);

            for(var rep=0; rep<RepCount; rep++)
            {
                var src = Random.Next<ulong>();

                dst.Clear();
                tmp.Clear();

                var expect = gbits.bitslice(src,0, (byte)spec.TotalWidth);

                bf.Deposit(src, dst);
                gspan.sllv(dst, positions, tmp);
                var result1 = or(tmp.ReadOnly());

                var result2 = 0ul;
                for(byte j=0; j<spec.FieldCount; j++)
                    result2 = gmath.or(result2, gmath.sll(dst[j], (byte)spec[j].StartPos));

                Claim.eq(result1, result2);

                if(expect != result1)
                {
                    Trace(src.FormatBits());
                    var config = BitFormatter.configure(true);
                    for(var i=0; i<dst.Length; i++)
                        Trace(dst[i].FormatBits(config));
                }

                Claim.eq(expect, result1);
            }
        }

        public void bitfield_IxW()
        {
            var spec = BitFieldModels.specify<BFD_I,BFD_W>();
            var bf = BitFields.create<ulong>(spec);
        }

        public void fixed_bits()
        {
            var bf = BitFields.create<BFD_I,byte,BFD_W>(64);
            bf.Content.Bytes.FormatBits(32);

            bf[3] = byte.MaxValue;

            Trace(bf.Content.Bytes.FormatBits(32));
        }

        public void bitfield_model()
        {
            var m = BitFieldModels.model("BitField1", new string[]{"Field1","Field2","Field3"}, new byte[]{4,8,3});
            Claim.eq((byte)0, m.Position(0));
            Claim.eq((byte)4, m.Position(1));
            Claim.eq((byte)12, m.Position(2));
            Claim.eq((byte)4, m.Width(0));
            Claim.eq((byte)8, m.Width(1));
            Claim.eq((byte)3, m.Width(2));
        }
    }
}