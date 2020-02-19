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
                => FieldSegments.define(segid.ToString(), evalue<E,byte>(segid), startpos, endpos, (byte)(endpos - startpos + 1));

        enum BF_A : byte
        {
            F08_0 = 0,
            
            F08_1 = 1,

            F08_2 = 2,

            F08_3 = 3
        }


        public void bitfield_a()
        {
            var bf = BitField.specify(
                segment(BF_A.F08_0, 0, 1),
                segment(BF_A.F08_1, 2, 3),
                segment(BF_A.F08_2, 4, 5),
                segment(BF_A.F08_3, 6, 7)
                );
            
            Claim.eq((byte)4, bf.FieldCount);
            Claim.eq((byte)0, bf[0].StartPos);
            Claim.eq((byte)2, bf[1].StartPos);
            Claim.eq((byte)4, bf[2].StartPos);
            Claim.eq((byte)6, bf[3].StartPos);
            Claim.eq((byte)2, bf[0].Width);
            Claim.eq((byte)2, bf[1].Width);
            Claim.eq((byte)2, bf[2].Width);
            Claim.eq((byte)2, bf[3].Width);

            var reader = bf.Reader<byte>();
            for(var rep=0; rep<RepCount; rep++)
            {
                var input = Random.Next<byte>();
                
                var seg0 = reader.Read(bf[0], input);            
                var seg1 = reader.Read(bf[1], input);
                var seg2 = reader.Read(bf[2], input);
                var seg3 = reader.Read(bf[3], input);

                Claim.eq(Bits.bitslice(input, 0, 2), seg0);
                Claim.eq(Bits.bitslice(input, 2, 2), seg1);
                Claim.eq(Bits.bitslice(input, 4, 2), seg2);
                Claim.eq(Bits.bitslice(input, 6, 2), seg3);

                var output =  gmath.or(
                    gmath.sll(seg0, bf[0].StartPos), 
                    gmath.sll(seg1, bf[1].StartPos), 
                    gmath.sll(seg2, bf[2].StartPos), 
                    gmath.sll(seg3, bf[3].StartPos));
                Claim.eq(input,output);

            }
        }

        enum BF_B : byte
        {
            F16_0 = 0,

            F16_1 = 1,

            F16_2 = 2,

            F16_3 = 3,
        }

        public void bitfield_b()
        {
            var bf = BitField.specify(
                segment(BF_B.F16_0, 0, 3),
                segment(BF_B.F16_1, 4, 7),
                segment(BF_B.F16_2, 8, 9),
                segment(BF_B.F16_3, 10, 15)
                );
            var dst = alloc<ushort>(bf.FieldCount);
            var reader = bf.Reader<ushort>();

            Claim.eq((byte)4,bf.FieldCount);

            for(var rep=0; rep<RepCount; rep++)
            {
                var src = Random.Next<ushort>();
                dst.Clear();
                reader.Read(src,dst);
                
                var output =  gmath.or(
                    gmath.sll(dst[0], bf[0].StartPos), 
                    gmath.sll(dst[1], bf[1].StartPos), 
                    gmath.sll(dst[2], bf[2].StartPos), 
                    gmath.sll(dst[3], bf[3].StartPos)
                );

                Claim.eq(src,output);

            }

        }

        //[F_0(0):0..3, F_1(1):4..7, F_2(2):8..9, F_3(3):10..15]
        enum BF_C : byte
        {
            F_0 = 4,

            F_1 = 4,

            F_2 = 2,

            F_3 = 6,
        }
        

        public void bitfield_c()
        {
            var bf = BitField.specify<BF_C>();
            var reader = bf.Reader<byte>();            
            var dst = alloc<byte>(bf.FieldCount);

            Claim.eq((byte)4, bf.FieldCount);

            for(var rep=0; rep<RepCount; rep++)
            {
                var src = Random.Next<byte>();
                                
                dst.Clear();
                reader.Read(src, dst);

                var result1 =  gmath.or(
                    gmath.sll(dst[0], bf[0].StartPos), 
                    gmath.sll(dst[1], bf[1].StartPos), 
                    gmath.sll(dst[2], bf[2].StartPos), 
                    gmath.sll(dst[3], bf[3].StartPos)
                    );

                var result2 = gmath.or(
                    reader.Read(bf[0], src, true),
                    reader.Read(bf[1], src, true),
                    reader.Read(bf[2], src, true),
                    reader.Read(bf[3], src, true)
                    );
                
                Claim.eq(src,result1);   
                Claim.eq(src,result2);   
            }
        }

        //[F1(0):0..7, F2(1):8..11, F3(2):12..13, F4(3):14..15, F5(4):16..18, F6(5):19..21, F7(6):22..26, F8(7):27..31, F9(8):32..40]
        enum BF_D : byte
        {            
            F1 = 8,
            
            F2 = 4,
            
            F3 = 2,
            
            F4 = 2,
            
            F5 = 3,

            F6 = 3,

            F7 = 5,

            F8 = 5,

            F9 = 9
        }

        public void bitfield_d()
        {
            var bf = BitField.specify<BF_D>();
            var reader = bf.Reader<ulong>();            
            var dst = alloc<ulong>(bf.FieldCount);
            var tmp = alloc<ulong>(bf.FieldCount);
            var positions = bf.Segments.Map(s => s.StartPos);

            Trace(bf);

            for(var rep=0; rep < RepCount; rep++)
            {
                var src = Random.Next<ulong>();
                                
                dst.Clear();
                tmp.Clear();

                var expect = gbits.bitslice(src,0, bf.TotalWidth);

                reader.Read(src, dst);
                mathspan.sllv(dst, positions, tmp);
                var result1 = mathspan.or(tmp.ReadOnly());
                                
                var result2 = 0ul;
                for(byte j=0; j<bf.FieldCount; j++)
                    result2 = gmath.or(result2, gmath.sll(dst[j], bf[j].StartPos));
                
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
    }
}