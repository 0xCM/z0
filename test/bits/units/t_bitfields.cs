//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

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
            var spec = BitFieldSpecs.define(
                BitFieldSpecs.part(BF_A.F08_0, 0, 1),
                BitFieldSpecs.part(BF_A.F08_1, 2, 3),
                BitFieldSpecs.part(BF_A.F08_2, 4, 5),
                BitFieldSpecs.part(BF_A.F08_3, 6, 7)
                );

            var segments = spec.Segments;
            using var writer = CaseWriter(LogExt);
            writer.WriteLine(spec);

            Claim.eq((byte)4, spec.FieldCount);
            Claim.eq((byte)0, spec[0].FirstIndex);
            Claim.eq((byte)2, spec[1].FirstIndex);
            Claim.eq((byte)4, spec[2].FirstIndex);
            Claim.eq((byte)6, spec[3].FirstIndex);

            Claim.eq((byte)1, spec[0].LastIndex);
            Claim.eq((byte)3, spec[1].LastIndex);
            Claim.eq((byte)5, spec[2].LastIndex);
            Claim.eq((byte)7, spec[3].LastIndex);

            Claim.eq((byte)2, spec[0].Width);
            Claim.eq((byte)2, spec[1].Width);
            Claim.eq((byte)2, spec[2].Width);
            Claim.eq((byte)2, spec[3].Width);

            var bf = BitFields.create<byte>(spec);
            for(var rep=0; rep<RepCount; rep++)
            {
                var input = Random.Next<byte>();
                bf = bf.State(input);
                writer.WriteLine(bf.Format());

                var seg0 = bf[0];
                var seg1 = bf[1];
                var seg2 = bf[2];
                var seg3 = bf[3];

                Claim.eq(Bits.extract(input, 0, 2), seg0);
                Claim.eq(Bits.extract(input, 2, 2), seg1);
                Claim.eq(Bits.extract(input, 4, 2), seg2);
                Claim.eq(Bits.extract(input, 6, 2), seg3);

                var output =  gmath.or(
                    gmath.sll(seg0, (byte)spec[0].FirstIndex),
                    gmath.sll(seg1, (byte)spec[1].FirstIndex),
                    gmath.sll(seg2, (byte)spec[2].FirstIndex),
                    gmath.sll(seg3, (byte)spec[3].FirstIndex));
                Claim.eq(input, output);
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
            var spec = BitFieldSpecs.define(
                BitFieldSpecs.part(BFB_I.BFB_0, 0, 3),
                BitFieldSpecs.part(BFB_I.BFB_1, 4, 7),
                BitFieldSpecs.part(BFB_I.BFB_2, 8, 9),
                BitFieldSpecs.part(BFB_I.BFB_3, 10, 15)
                );
            using var writer = CaseWriter(LogExt);
            writer.WriteLine(spec);

            var dst = memory.alloc<ushort>(spec.FieldCount);
            var bf = BitFields.create<ushort>(spec);

            Claim.eq((byte)4,spec.FieldCount);

            for(var rep=0; rep<RepCount; rep++)
            {
                var input = Random.Next<ushort>();
                dst.Clear();
                bf = bf.State(input);
                writer.WriteLine(bf.Format());

                BitFields.deposit(bf.Spec, input, dst);

                var output =  gmath.or(
                    gmath.sll(dst[0], (byte)spec[0].FirstIndex),
                    gmath.sll(dst[1], (byte)spec[1].FirstIndex),
                    gmath.sll(dst[2], (byte)spec[2].FirstIndex),
                    gmath.sll(dst[3], (byte)spec[3].FirstIndex)
                );

                Claim.eq(input,output);
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
            var spec = BitFieldSpecs.define<BFC_I,BFC_W>();
            var bf = BitFields.create<byte>(spec);
            var dst = alloc<byte>(spec.FieldCount);
            using var writer = CaseWriter(LogExt);
            writer.WriteLine(spec);

            Claim.eq((byte)4, spec.FieldCount);

            for(var rep=0; rep<RepCount; rep++)
            {
                var input = Random.Next<byte>();
                bf = bf.State(input);
                writer.WriteLine(bf.Format());
                dst.Clear();

                BitFields.deposit(bf.Spec, input, dst);

                var result1 =  gmath.or(
                    gmath.sll(dst[0], (byte)spec[0].FirstIndex),
                    gmath.sll(dst[1], (byte)spec[1].FirstIndex),
                    gmath.sll(dst[2], (byte)spec[2].FirstIndex),
                    gmath.sll(dst[3], (byte)spec[3].FirstIndex)
                    );

                var result2 = gmath.or(
                    BitFields.offset(spec[0], input),
                    BitFields.offset(spec[1], input),
                    BitFields.offset(spec[2], input),
                    BitFields.offset(spec[3], input)
                    );

                Claim.eq(input,result1);
                Claim.eq(input,result2);
            }
        }

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
                result = MSvc.or<T>().Invoke(result, skip(src,(uint)i));
            return result;
        }

        public void bitfield_d()
        {
            var spec = BitFieldSpecs.define<BFD_I,BFD_W>();
            var bf = BitFields.create<ulong>(spec);
            var dst = span(alloc<ulong>(spec.FieldCount));
            var tmp = span(alloc<ulong>(spec.FieldCount));
            var positions = spec.Segments.Map(s => (byte)s.FirstIndex);
            using var writer = CaseWriter(FS.Extensions.Log);
            writer.WriteLine(spec);

            for(var rep=0; rep<RepCount; rep++)
            {
                var input = Random.Next<ulong>();
                bf = bf.State(input);
                writer.WriteLine(bf.Format());

                dst.Clear();
                tmp.Clear();

                var expect = gbits.extract(input,0, (byte)spec.TotalWidth);

                BitFields.deposit(bf.Spec, input, dst);

                gspan.sllv(dst, positions, tmp);
                var result1 = or(tmp.ReadOnly());

                var result2 = 0ul;
                for(byte j=0; j<spec.FieldCount; j++)
                    result2 = gmath.or(result2, gmath.sll(dst[j], (byte)spec[j].FirstIndex));

                Claim.eq(result1, result2);

                if(expect != result1)
                {
                    Trace(input.FormatBits());
                    var config = BitFormatter.configure(true);
                    for(var i=0; i<dst.Length; i++)
                        Trace(dst[i].FormatBits(config));
                }

                Claim.eq(expect, result1);
            }
        }

        public void bitfield_IxW()
        {
            var spec = BitFieldSpecs.define<BFD_I,BFD_W>();
            var bf = BitFields.create<ulong>(spec);
        }

        public void fixed_bits()
        {
            var bf = BitFields.fixedbits<BFD_I,byte,BFD_W>(64);
            bf[3] = byte.MaxValue;

        }

        public void bitfield_model()
        {
            var model = BitFieldSpecs.model("BitField1", new string[]{"Field0","Field1","Field2"}, new byte[]{4,8,3});
            Claim.eq(model.SegmentCount,3);

            ref readonly var seg0 = ref model.Segment(0);
            Claim.eq(seg0.Name, "Field0");

            ref readonly var seg1 = ref model.Segment(1);
            Claim.eq(seg1.Name, "Field1");

            ref readonly var seg2 = ref model.Segment(2);
            Claim.eq(seg2.Name, "Field2");
        }
    }
}