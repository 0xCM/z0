//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;


    public class t_bitfields : t_bitcore<t_bitfields>
    {
        [MethodImpl(Inline)]
        public static FieldSegment segment<E>(E segid, byte startpos, byte endpos)
            where E : unmanaged, Enum
                => BitFieldSpecs.segment(segid, startpos, endpos); 
                
        enum BF_A : byte
        {
            F08_0 = 0,
            
            F08_1 = 1,

            F08_2 = 2,

            F08_3 = 3
        }


        public void primal_kind()
        {
            var f = PrimalKindBitFields.Init(PrimalKind.I16);
            var width = f.FieldWidth;
            Claim.Eq(width, Pow2Width.w16);            
        }

        public void bitfield_a()
        {
            var spec = BitFieldSpecs.specify(
                segment(BF_A.F08_0, 0, 1),
                segment(BF_A.F08_1, 2, 3),
                segment(BF_A.F08_2, 4, 5),
                segment(BF_A.F08_3, 6, 7)
                );

            
            Claim.eq((byte)4, spec.FieldCount);
            Claim.Eq((byte)0, spec[0].StartPos);
            Claim.Eq((byte)2, spec[1].StartPos);
            Claim.Eq((byte)4, spec[2].StartPos);
            Claim.Eq((byte)6, spec[3].StartPos);
            Claim.Eq((byte)2, spec[0].Width);
            Claim.Eq((byte)2, spec[1].Width);
            Claim.Eq((byte)2, spec[2].Width);
            Claim.Eq((byte)2, spec[3].Width);

            var bf = BitFields.create<byte>(spec);
            for(var rep=0; rep<RepCount; rep++)
            {
                var input = Random.Next<byte>();
                
                var seg0 = bf.Extract(spec[0], input);            
                var seg1 = bf.Extract(spec[1], input);
                var seg2 = bf.Extract(spec[2], input);
                var seg3 = bf.Extract(spec[3], input);

                Claim.Eq(Bits.slice(input, 0, 2), seg0);
                Claim.Eq(Bits.slice(input, 2, 2), seg1);
                Claim.Eq(Bits.slice(input, 4, 2), seg2);
                Claim.Eq(Bits.slice(input, 6, 2), seg3);

                var output =  gmath.or(
                    gmath.sll(seg0, spec[0].StartPos), 
                    gmath.sll(seg1, spec[1].StartPos), 
                    gmath.sll(seg2, spec[2].StartPos), 
                    gmath.sll(seg3, spec[3].StartPos));
                Claim.Eq(input,output);

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
            var spec = BitFieldSpecs.specify(
                segment(BFB_I.BFB_0, 0, 3),
                segment(BFB_I.BFB_1, 4, 7),
                segment(BFB_I.BFB_2, 8, 9),
                segment(BFB_I.BFB_3, 10, 15)
                );
            var dst = Root.alloc<ushort>(spec.FieldCount);
            var bf = BitFields.create<ushort>(spec);

            Claim.eq((byte)4,spec.FieldCount);

            for(var rep=0; rep<RepCount; rep++)
            {
                var src = Random.Next<ushort>();
                dst.Clear();
                bf.Deposit(src,dst);
                
                var output =  gmath.or(
                    gmath.sll(dst[0], spec[0].StartPos), 
                    gmath.sll(dst[1], spec[1].StartPos), 
                    gmath.sll(dst[2], spec[2].StartPos), 
                    gmath.sll(dst[3], spec[3].StartPos)
                );

                Claim.Eq(src,output);
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
            var spec = BitFieldSpecs.specify<BFC_I,BFC_W>();
            var bf = BitFields.create<byte>(spec);
            var dst = Root.alloc<byte>(spec.FieldCount);

            Claim.eq((byte)4, spec.FieldCount);

            for(var rep=0; rep<RepCount; rep++)
            {
                var src = Random.Next<byte>();
                                
                dst.Clear();
                bf.Deposit(src, dst);

                var result1 =  gmath.or(
                    gmath.sll(dst[0], spec[0].StartPos), 
                    gmath.sll(dst[1], spec[1].StartPos), 
                    gmath.sll(dst[2], spec[2].StartPos), 
                    gmath.sll(dst[3], spec[3].StartPos)
                    );

                var result2 = gmath.or(
                    bf.Extract(spec[0], src, true),
                    bf.Extract(spec[1], src, true),
                    bf.Extract(spec[2], src, true),
                    bf.Extract(spec[3], src, true)
                    );
                
                Claim.Eq(src,result1);   
                Claim.Eq(src,result2);   
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
                result = MSvc.or<T>().Invoke(result, refs.skip(src,i));
            return result;
        }                

        public void bitfield_d()
        {
            var spec = BitFieldSpecs.specify<BFD_I,BFD_W>();
            var bf = BitFields.create<ulong>(spec);
            var dst = Root.span(Root.alloc<ulong>(spec.FieldCount));
            var tmp = Root.span(Root.alloc<ulong>(spec.FieldCount));
            var positions = spec.Segments.Map(s => s.StartPos);

            Trace(spec);

            for(var rep=0; rep < RepCount; rep++)
            {
                var src = Random.Next<ulong>();
                                
                dst.Clear();
                tmp.Clear();

                var expect = gbits.slice(src,0, (byte)spec.TotalWidth);

                bf.Deposit(src, dst);
                gspan.sllv(dst, positions, tmp);
                var result1 = or(tmp.ReadOnly());
                                
                var result2 = 0ul;
                for(byte j=0; j<spec.FieldCount; j++)
                    result2 = gmath.or(result2, gmath.sll(dst[j], spec[j].StartPos));
                
                Claim.Eq(result1, result2);
                
                if(expect != result1)
                {
                    Trace(src.FormatBits());
                    for(var i=0; i<dst.Length; i++)
                        Trace(dst[i].FormatBits(BitFormatConfig.Tlz));
                }


                Claim.Eq(expect, result1);
            }
        }

        public void bitfield_IxW()
        {
            var spec = BitFieldSpecs.specify<BFD_I,BFD_W>();
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
            var m = BitFieldSpecs.model("BitsInField", new string[]{"Field1","Field2","Field3"}, new byte[]{4,8,3});
            Claim.Eq((byte)0, m.Position(0));
            Claim.Eq((byte)4, m.Position(1));
            Claim.Eq((byte)12, m.Position(2));
            Claim.Eq((byte)4, m.Width(0));
            Claim.Eq((byte)8, m.Width(1));
            Claim.Eq((byte)3, m.Width(2));
            Claim.eq("Field1", m.Name(0));
            Claim.eq("Field2", m.Name(1));
            Claim.eq("Field3", m.Name(2));


        }
    }
}