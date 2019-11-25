//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_nbv_rev : t_bv<t_nbv_rev>
    {
        public void nbv_rev_2x8()
            => nbv_rev_check<N2,byte>();

        public void nbv_rev_3x8()
            => nbv_rev_check<N3,byte>();

        public void nbv_rev_4x8()
            => nbv_rev_check<N4,byte>();

        public void nbv_rev_5x8()
            => nbv_rev_check<N5,byte>();

        public void nbv_rev_6x8()
            => nbv_rev_check<N6,byte>();

        public void nbv_rev_7x8()
            => nbv_rev_check<N7,byte>();

        public void nbv_rev_8x8()
            => nbv_rev_check<N8,byte>();

        public void nbv_rev_2x16()
            => nbv_rev_check<N2,ushort>();

        public void nbv_rev_3x16()
            => nbv_rev_check<N3,ushort>();

        public void nbv_rev_4x16()
            => nbv_rev_check<N4,ushort>();

        public void nbv_rev_5x16()
            => nbv_rev_check<N5,ushort>();

        public void nbv_rev_6x16()
            => nbv_rev_check<N6,ushort>();

        public void nbv_rev_7x16()
            => nbv_rev_check<N7,ushort>();

        public void nbv_rev_8x16()
            => nbv_rev_check<N8,ushort>();

        public void nbv_rev_9x16()
            => nbv_rev_check<N9,ushort>();

        public void nbv_rev_10x16()
            => nbv_rev_check<N10,ushort>();

        public void nbv_rev_11x16()
            => nbv_rev_check<N11,ushort>();

        public void nbv_rev_12x16()
            => nbv_rev_check<N12,ushort>();

        public void nbv_rev_13x16()
            => nbv_rev_check<N13,ushort>();

        public void nbv_rev_14x16()
            => nbv_rev_check<N14,ushort>();

        public void nbv_rev_15x16()
            => nbv_rev_check<N15,ushort>();

        public void nbv_rev_16x16()
            => nbv_rev_check<N16,ushort>();

        public void nbv_rev_2x32()
            => nbv_rev_check<N2,uint>();

        public void nbv_rev_3x32()
            => nbv_rev_check<N3,uint>();

        public void nbv_rev_4x32()
            => nbv_rev_check<N4,uint>();

        public void nbv_rev_5x32()
            => nbv_rev_check<N5,uint>();

        public void nbv_rev_6x32()
            => nbv_rev_check<N6,uint>();

        public void nbv_rev_7x32()
            => nbv_rev_check<N7,uint>();

        public void nbv_rev_8x32()
            => nbv_rev_check<N8,uint>();

        public void nbv_rev_9x32()
            => nbv_rev_check<N9,uint>();

        public void nbv_rev_10x32()
            => nbv_rev_check<N10,uint>();

        public void nbv_rev_11x32()
            => nbv_rev_check<N11,uint>();

        public void nbv_rev_12x32()
            => nbv_rev_check<N12,uint>();

        public void nbv_rev_13x32()
            => nbv_rev_check<N13,uint>();

        public void nbv_rev_14x32()
            => nbv_rev_check<N14,uint>();

        public void nbv_rev_15x32()
            => nbv_rev_check<N15,uint>();

        public void nbv_rev_16x32()
            => nbv_rev_check<N16,uint>();

        public void nbv_rev_17x32()
            => nbv_rev_check<N17,uint>();

        public void nbv_rev_18x32()
            => nbv_rev_check<N18,uint>();

        public void nbv_rev_19x32()
            => nbv_rev_check<N19,uint>();

        public void nbv_rev_20x32()
            => nbv_rev_check<N20,uint>();

        public void nbv_rev_21x32()
            => nbv_rev_check<N21,uint>();

        public void nbv_rev_22x32()
            => nbv_rev_check<N22,uint>();

        public void nbv_rev_23x32()
            => nbv_rev_check<N23,uint>();

        public void nbv_rev_24x32()
            => nbv_rev_check<N24,uint>();

        public void nbv_rev_25x32()
            => nbv_rev_check<N25,uint>();

        public void nbv_rev_26x32()
            => nbv_rev_check<N26,uint>();

        public void nbv_rev_27x32()
            => nbv_rev_check<N27,uint>();

        public void nbv_rev_28x32()
            => nbv_rev_check<N28,uint>();

        public void nbv_rev_29x32()
            => nbv_rev_check<N29,uint>();

        public void nbv_rev_30x32()
            => nbv_rev_check<N30,uint>();

        public void nbv_rev_31x32()
            => nbv_rev_check<N31,uint>();

        public void nbv_rev_32x32()
            => nbv_rev_check<N32,uint>();

        public void nbv_rev_2x64()
            => nbv_rev_check<N2,ulong>();

        public void nbv_rev_3x64()
            => nbv_rev_check<N3,ulong>();

        public void nbv_rev_4x64()
            => nbv_rev_check<N4,ulong>();

        public void nbv_rev_5x64()
            => nbv_rev_check<N5,ulong>();

        public void nbv_rev_6x64()
            => nbv_rev_check<N6,ulong>();

        public void nbv_rev_7x64()
            => nbv_rev_check<N7,ulong>();

        public void nbv_rev_8x64()
            => nbv_rev_check<N8,ulong>();

        public void nbv_rev_9x64()
            => nbv_rev_check<N9,ulong>();

        public void nbv_rev_10x64()
            => nbv_rev_check<N10,ulong>();

        public void nbv_rev_11x64()
            => nbv_rev_check<N11,ulong>();

        public void nbv_rev_12x64()
            => nbv_rev_check<N12,ulong>();

        public void nbv_rev_13x64()
            => nbv_rev_check<N13,ulong>();

        public void nbv_rev_14x64()
            => nbv_rev_check<N14,ulong>();

        public void nbv_rev_15x64()
            => nbv_rev_check<N15,ulong>();

        public void nbv_rev_16x64()
            => nbv_rev_check<N16,ulong>();

        public void nbv_rev_17x64()
            => nbv_rev_check<N17,ulong>();

        public void nbv_rev_18x64()
            => nbv_rev_check<N18,ulong>();

        public void nbv_rev_19x64()
            => nbv_rev_check<N19,ulong>();

        public void nbv_rev_20x64()
            => nbv_rev_check<N20,ulong>();

        public void nbv_rev_21x64()
            => nbv_rev_check<N21,ulong>();

        public void nbv_rev_22x64()
            => nbv_rev_check<N22,ulong>();

        public void nbv_rev_23x64()
            => nbv_rev_check<N23,ulong>();

        public void nbv_rev_24x64()
            => nbv_rev_check<N24,ulong>();

        public void nbv_rev_25x64()
            => nbv_rev_check<N25,ulong>();

        public void nbv_rev_26x64()
            => nbv_rev_check<N26,ulong>();

        public void nbv_rev_27x64()
            => nbv_rev_check<N27,ulong>();

        public void nbv_rev_28x64()
            => nbv_rev_check<N28,ulong>();

        public void nbv_rev_29x64()
            => nbv_rev_check<N29,ulong>();

        public void nbv_rev_30x64()
            => nbv_rev_check<N30,ulong>();

        public void nbv_rev_31x64()
            => nbv_rev_check<N31,ulong>();

        public void nbv_rev_32x64()
            => nbv_rev_check<N32,ulong>();

        public void nbv_rev_33x64()
            => nbv_rev_check<N33,ulong>();

        public void nbv_rev_34x64()
            => nbv_rev_check<N34,ulong>();

        public void nbv_rev_35x64()
            => nbv_rev_check<N35,ulong>();

        public void nbv_rev_36x64()
            => nbv_rev_check<N36,ulong>();

        public void nbv_rev_37x64()
            => nbv_rev_check<N37,ulong>();

        public void nbv_rev_38x64()
            => nbv_rev_check<N38,ulong>();

        public void nbv_rev_39x64()
            => nbv_rev_check<N39,ulong>();

        public void nbv_rev_40x64()
            => nbv_rev_check<N40,ulong>();
        
        public void nbv_rev_41x64()
            => nbv_rev_check<N41,ulong>();

        public void nbv_rev_42x64()
            => nbv_rev_check<N42,ulong>();

        public void nbv_rev_43x64()
            => nbv_rev_check<N43,ulong>();

        public void nbv_rev_44x64()
            => nbv_rev_check<N44,ulong>();

        public void nbv_rev_45x64()
            => nbv_rev_check<N45,ulong>();

        public void nbv_rev_46x64()
            => nbv_rev_check<N46,ulong>();

        public void nbv_rev_47x64()
            => nbv_rev_check<N47,ulong>();

        public void nbv_rev_48x64()
            => nbv_rev_check<N48,ulong>();

        public void nbv_rev_49x64()
            => nbv_rev_check<N49,ulong>();

        public void nbv_rev_50x64()
            => nbv_rev_check<N50,ulong>();

        public void nbv_rev_51x64()
            => nbv_rev_check<N51,ulong>();

        public void nbv_rev_52x64()
            => nbv_rev_check<N52,ulong>();

        public void nbv_rev_53x64()
            => nbv_rev_check<N53,ulong>();

        public void nbv_rev_54x64()
            => nbv_rev_check<N54,ulong>();

        public void nbv_rev_55x64()
            => nbv_rev_check<N55,ulong>();

        public void nbv_rev_56x64()
            => nbv_rev_check<N56,ulong>();

        public void nbv_rev_57x64()
            => nbv_rev_check<N57,ulong>();

        public void nbv_rev_58x64()
            => nbv_rev_check<N58,ulong>();

        public void nbv_rev_59x64()
            => nbv_rev_check<N59,ulong>();

        public void nbv_rev_60x64()
            => nbv_rev_check<N60,ulong>();

        public void nbv_rev_61x64()
            => nbv_rev_check<N61,ulong>();
        
        public void nbv_rev_62x64()
            => nbv_rev_check<N62,ulong>();

        public void nbv_rev_63x64()
            => nbv_rev_check<N63,ulong>();

        public void nbv_rev_64x64()
            => nbv_rev_check<N64,ulong>();
 

    }


}