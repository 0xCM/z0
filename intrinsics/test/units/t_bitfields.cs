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
    using static BF8_A;

    enum BF8_A : byte
    {
        F08_0 = 0,
        
        F08_1 = 1,

        F08_2 = 2,

        F08_3 = 3
    }



    public class t_bitfields : t_vinx<t_bitfields>
    {
        public void bitfield_8()
        {
            var bf = BitField.specify<BF8_A,byte>(
                BitField.segment(BF8_A.F08_0, 0, 1),
                BitField.segment(BF8_A.F08_1, 2, 3),
                BitField.segment(BF8_A.F08_2, 4, 5),
                BitField.segment(BF8_A.F08_3, 6, 7)
                );
            
            Claim.ueq(4, bf.FieldCount);

            var reader = BitField.reader(bf);
            for(var rep=0; rep<RepCount; rep++)
            {
                var input = Random.Next<byte>();
                var seg0 = reader.ReadValue(BF8_A.F08_0, input);
                var seg1 = reader.ReadValue(BF8_A.F08_1, input);
                var seg2 = reader.ReadValue(BF8_A.F08_2, input);
                var seg3 = reader.ReadValue(BF8_A.F08_3, input);
                var output =  gmath.or(
                    gmath.sll(seg0, bf.Segment((byte)BF8_A.F08_0).StartPos), 
                    gmath.sll(seg1, bf.Segment((byte)BF8_A.F08_1).StartPos), 
                    gmath.sll(seg2, bf.Segment((byte)BF8_A.F08_2).StartPos), 
                    gmath.sll(seg3, bf.Segment((byte)BF8_A.F08_3).StartPos));
                Claim.eq(input,output);

            }
        }

        enum BF16_A : byte
        {
            F16_0 = 0,

            F16_1 = 1,

            F16_2 = 2,

            F16_3 = 3,
        }

        public void bitfield_16_A()
        {
            var bf = BitField.specify<BF16_A,ushort>(
                BitField.segment(BF16_A.F16_0, 0, 3),
                BitField.segment(BF16_A.F16_1, 4, 7),
                BitField.segment(BF16_A.F16_2, 8, 9),
                BitField.segment(BF16_A.F16_3, 10, 15)
                );
            Span<ushort> segs = new ushort[bf.FieldCount];
            var reader = BitField.reader(bf);

            Claim.ueq(4,bf.FieldCount);

            for(var rep=0; rep<RepCount; rep++)
            {
                var input = Random.Next<ushort>();
                segs.Clear();
                for(byte j=0; j<bf.FieldCount; j++)
                    segs[j] = reader.ReadValue(bf[j], input);
                
                // var seg0 = reader.ReadValue(bf[0], input);
                // var seg1 = reader.ReadValue(bf[1], input);
                // var seg2 = reader.ReadValue(bf[2], input);
                // var seg3 = reader.ReadValue(bf[3], input);
                var output =  gmath.or(
                    gmath.sll(segs[0], bf.Segment((byte)BF16_A.F16_0).StartPos), 
                    gmath.sll(segs[1], bf.Segment((byte)BF16_A.F16_1).StartPos), 
                    gmath.sll(segs[2], bf.Segment((byte)BF16_A.F16_2).StartPos), 
                    gmath.sll(segs[3], bf.Segment((byte)BF16_A.F16_3).StartPos));

                Claim.eq(input,output);

            }

        }

        //[F16_0(0):0..3, F16_1(1):4..7, F16_2(2):8..9, F16_3(3):10..15]
        enum BF16_B : byte
        {
            F16_0 = 4,

            F16_1 = 4,

            F16_2 = 2,

            F16_3 = 6,

        }

        public void bitfield_16_B()
        {
            var bf = BitField.specify<BF16_B,ushort>();
            var reader = BitField.reader(bf);            
            Span<ushort> segs = new ushort[bf.FieldCount];

            Claim.ueq(4, bf.FieldCount);


            for(var rep=0; rep<RepCount; rep++)
            {
                var input = Random.Next<ushort>();
                var bsInput = input.ToBitSpan();
                
                segs.Clear();
                for(byte j=0; j<bf.FieldCount; j++)
                    segs[j] = reader.ReadValue(bf[j], input);

                var bsOutput = 
                    segs[3].ToBitString(bf.Segment(3).Width).Concat(
                    segs[2].ToBitString(bf.Segment(2).Width),
                    segs[1].ToBitString(bf.Segment(1).Width), 
                    segs[0].ToBitString(bf.Segment(0).Width));

                var output =  gmath.or(
                    gmath.sll(segs[0], bf.Segment(0).StartPos), 
                    gmath.sll(segs[1], bf.Segment(1).StartPos), 
                    gmath.sll(segs[2], bf.Segment(2).StartPos), 
                    gmath.sll(segs[3], bf.Segment(3).StartPos)
                    );
                
                Claim.eq(input,output);   
                Claim.eq(bsOutput, output.ToBitString());
            }
        }
    }
}