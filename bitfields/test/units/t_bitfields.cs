//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public class t_bitfields : UnitTest<t_bitfields>
    {
        [MethodImpl(Inline)]
        public static FieldSegment segment<E>(E segid, byte startpos, byte endpos)
            where E : unmanaged, Enum
                => BitField.segment(segid.ToString(), evalue<E,byte>(segid), startpos, endpos, (byte)(endpos - startpos + 1));

        enum BF_A : byte
        {
            F08_0 = 0,
            
            F08_1 = 1,

            F08_2 = 2,

            F08_3 = 3
        }


        public void bitfield_a()
        {
            var spec = BitField.specify(
                segment(BF_A.F08_0, 0, 1),
                segment(BF_A.F08_1, 2, 3),
                segment(BF_A.F08_2, 4, 5),
                segment(BF_A.F08_3, 6, 7)
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

            var bf = BitField.create<byte>(spec);
            for(var rep=0; rep<RepCount; rep++)
            {
                var input = Random.Next<byte>();
                
                var seg0 = bf.Read(spec[0], input);            
                var seg1 = bf.Read(spec[1], input);
                var seg2 = bf.Read(spec[2], input);
                var seg3 = bf.Read(spec[3], input);

                Claim.eq(Bits.bitslice(input, 0, 2), seg0);
                Claim.eq(Bits.bitslice(input, 2, 2), seg1);
                Claim.eq(Bits.bitslice(input, 4, 2), seg2);
                Claim.eq(Bits.bitslice(input, 6, 2), seg3);

                var output =  gmath.or(
                    gmath.sll(seg0, spec[0].StartPos), 
                    gmath.sll(seg1, spec[1].StartPos), 
                    gmath.sll(seg2, spec[2].StartPos), 
                    gmath.sll(seg3, spec[3].StartPos));
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
            var spec = BitField.specify(
                segment(BFB_I.BFB_0, 0, 3),
                segment(BFB_I.BFB_1, 4, 7),
                segment(BFB_I.BFB_2, 8, 9),
                segment(BFB_I.BFB_3, 10, 15)
                );
            var dst = alloc<ushort>(spec.FieldCount);
            var bf = BitField.create<ushort>(spec);

            Claim.eq((byte)4,spec.FieldCount);

            for(var rep=0; rep<RepCount; rep++)
            {
                var src = Random.Next<ushort>();
                dst.Clear();
                bf.Read(src,dst);
                
                var output =  gmath.or(
                    gmath.sll(dst[0], spec[0].StartPos), 
                    gmath.sll(dst[1], spec[1].StartPos), 
                    gmath.sll(dst[2], spec[2].StartPos), 
                    gmath.sll(dst[3], spec[3].StartPos)
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
            var spec = BitField.specify<BFC_I, BFC_W>();
            var bf = BitField.create<byte>(spec);
            var dst = alloc<byte>(spec.FieldCount);

            Claim.eq((byte)4, spec.FieldCount);

            for(var rep=0; rep<RepCount; rep++)
            {
                var src = Random.Next<byte>();
                                
                dst.Clear();
                bf.Read(src, dst);

                var result1 =  gmath.or(
                    gmath.sll(dst[0], spec[0].StartPos), 
                    gmath.sll(dst[1], spec[1].StartPos), 
                    gmath.sll(dst[2], spec[2].StartPos), 
                    gmath.sll(dst[3], spec[3].StartPos)
                    );

                var result2 = gmath.or(
                    bf.Read(spec[0], src, true),
                    bf.Read(spec[1], src, true),
                    bf.Read(spec[2], src, true),
                    bf.Read(spec[3], src, true)
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

        public void bitfield_d()
        {
            var spec = BitField.specify<BFD_I,BFD_W>();
            var bf = BitField.create<ulong>(spec);
            var dst = alloc<ulong>(spec.FieldCount);
            var tmp = alloc<ulong>(spec.FieldCount);
            var positions = spec.Segments.Map(s => s.StartPos);

            Trace(spec);

            for(var rep=0; rep < RepCount; rep++)
            {
                var src = Random.Next<ulong>();
                                
                dst.Clear();
                tmp.Clear();

                var expect = gbits.bitslice(src,0, spec.TotalWidth);

                bf.Read(src, dst);
                mathspan.sllv(dst, positions, tmp);
                var result1 = mathspan.or(tmp.ReadOnly());
                                
                var result2 = 0ul;
                for(byte j=0; j<spec.FieldCount; j++)
                    result2 = gmath.or(result2, gmath.sll(dst[j], spec[j].StartPos));
                
                Claim.eq(result1, result2);
                
                if(expect != result1)
                {
                    Trace(src.FormatBits());
                    for(var i=0; i<dst.Length; i++)
                        Trace(dst[i].FormatBits(tlz:true));
                }


                Claim.eq(expect, result1);
            }
        }

        public void bitfield_IxW()
        {
            var spec = BitField.specify<BFD_I,BFD_W>();
            var bf = BitField.create<ulong>(spec);

        }

        public void fixed_bits()
        {
            var bf = BitField.@fixed<BFD_I,byte,BFD_W>(64);

            bf[3] = byte.MaxValue;
            Trace(bf.FormatBits(32));                            

        }
    }
}