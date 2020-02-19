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
        enum BF_A : byte
        {
            F08_0 = 0,
            
            F08_1 = 1,

            F08_2 = 2,

            F08_3 = 3
        }


        public void bitfield_a()
        {
            var bf = BitField.specify<BF_A>(
                BitField.segment(BF_A.F08_0, 0, 1),
                BitField.segment(BF_A.F08_1, 2, 3),
                BitField.segment(BF_A.F08_2, 4, 5),
                BitField.segment(BF_A.F08_3, 6, 7)
                );
            
            Claim.ueq(4, bf.FieldCount);

            var reader = bf.Reader<byte>();
            for(var rep=0; rep<RepCount; rep++)
            {
                var input = Random.Next<byte>();
                var seg0 = reader.Read(bf[0], input);
                var seg1 = reader.Read(bf[1], input);
                var seg2 = reader.Read(bf[2], input);
                var seg3 = reader.Read(bf[3], input);
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
            var bf = BitField.specify<BF_B>(
                BitField.segment(BF_B.F16_0, 0, 3),
                BitField.segment(BF_B.F16_1, 4, 7),
                BitField.segment(BF_B.F16_2, 8, 9),
                BitField.segment(BF_B.F16_3, 10, 15)
                );
            var dst = span<ushort>(bf.FieldCount);
            var reader = bf.Reader<ushort>();

            Claim.ueq(4,bf.FieldCount);

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
            var reader = bf.Reader<ushort>();            
            var dst = span<ushort>(bf.FieldCount);

            Claim.ueq(4, bf.FieldCount);

            for(var rep=0; rep<RepCount; rep++)
            {
                var src = Random.Next<ushort>();
                                
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
            var dst = span<ulong>(bf.FieldCount);
            Trace(bf);

            for(var rep=0; rep<RepCount; rep++)
            {
                var src = Random.Next<ulong>();
                                
                dst.Clear();
                reader.Read(src, dst);

                var result = 0ul;
                for(byte j=0; j<bf.FieldCount; j++)
                    result = gmath.or(result, gmath.sll(dst[j], bf[j].StartPos));
                
                
                //Claim.eq(src, result);
            }

        }

    }
}