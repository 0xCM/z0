//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_bitspan_from : UnitTest<t_bitspan_from>
    {
        public void bitspan_2x8()
            => bitspan_check<N2,byte>();

        public void bitspan_3x8()
            => bitspan_check<N3,byte>();

        public void bitspan_4x8()
            => bitspan_check<N4,byte>();

        public void bitspan_5x8()
            => bitspan_check<N5,byte>();

        public void bitspan_6x8()
            => bitspan_check<N6,byte>();

        public void bitspan_7x8()
            => bitspan_check<N7,byte>();

        public void bitspan_8x8()
            => bitspan_check<N8,byte>();

        public void bitspan_2x16()
            => bitspan_check<N2,ushort>();

        public void bitspan_3x16()
            => bitspan_check<N3,ushort>();

        public void bitspan_4x16()
            => bitspan_check<N4,ushort>();

        public void bitspan_5x16()
            => bitspan_check<N5,ushort>();

        public void bitspan_6x16()
            => bitspan_check<N6,ushort>();

        public void bitspan_7x16()
            => bitspan_check<N7,ushort>();

        public void bitspan_8x16()
            => bitspan_check<N8,ushort>();

        public void bitspan_9x16()
            => bitspan_check<N9,ushort>();

        public void bitspan_10x16()
            => bitspan_check<N10,ushort>();

        public void bitspan_11x16()
            => bitspan_check<N11,ushort>();

        public void bitspan_12x16()
            => bitspan_check<N12,ushort>();

        public void bitspan_13x16()
            => bitspan_check<N13,ushort>();

        public void bitspan_14x16()
            => bitspan_check<N14,ushort>();

        public void bitspan_15x16()
            => bitspan_check<N15,ushort>();

        public void bitspan_16x16()
            => bitspan_check<N16,ushort>();

        public void bitspan_2x32()
            => bitspan_check<N2,uint>();

        public void bitspan_3x32()
            => bitspan_check<N3,uint>();

        public void bitspan_4x32()
            => bitspan_check<N4,uint>();

        public void bitspan_5x32()
            => bitspan_check<N5,uint>();

        public void bitspan_6x32()
            => bitspan_check<N6,uint>();

        public void bitspan_7x32()
            => bitspan_check<N7,uint>();

        public void bitspan_8x32()
            => bitspan_check<N8,uint>();

        public void bitspan_9x32()
            => bitspan_check<N9,uint>();

        public void bitspan_10x32()
            => bitspan_check<N10,uint>();

        public void bitspan_11x32()
            => bitspan_check<N11,uint>();

        public void bitspan_12x32()
            => bitspan_check<N12,uint>();

        public void bitspan_13x32()
            => bitspan_check<N13,uint>();

        public void bitspan_14x32()
            => bitspan_check<N14,uint>();

        public void bitspan_15x32()
            => bitspan_check<N15,uint>();

        public void bitspan_16x32()
            => bitspan_check<N16,uint>();

        public void bitspan_17x32()
            => bitspan_check<N17,uint>();

        public void bitspan_18x32()
            => bitspan_check<N18,uint>();

        public void bitspan_19x32()
            => bitspan_check<N19,uint>();

        public void bitspan_20x32()
            => bitspan_check<N20,uint>();

        public void bitspan_21x32()
            => bitspan_check<N21,uint>();

        public void bitspan_22x32()
            => bitspan_check<N22,uint>();

        public void bitspan_23x32()
            => bitspan_check<N23,uint>();

        public void bitspan_24x32()
            => bitspan_check<N24,uint>();

        public void bitspan_25x32()
            => bitspan_check<N25,uint>();

        public void bitspan_26x32()
            => bitspan_check<N26,uint>();

        public void bitspan_27x32()
            => bitspan_check<N27,uint>();

        public void bitspan_28x32()
            => bitspan_check<N28,uint>();

        public void bitspan_29x32()
            => bitspan_check<N29,uint>();

        public void bitspan_30x32()
            => bitspan_check<N30,uint>();

        public void bitspan_31x32()
            => bitspan_check<N31,uint>();

        public void bitspan_32x32()
            => bitspan_check<N32,uint>();

        public void bitspan_2x64()
            => bitspan_check<N2,ulong>();

        public void bitspan_3x64()
            => bitspan_check<N3,ulong>();

        public void bitspan_4x64()
            => bitspan_check<N4,ulong>();

        public void bitspan_5x64()
            => bitspan_check<N5,ulong>();

        public void bitspan_6x64()
            => bitspan_check<N6,ulong>();

        public void bitspan_7x64()
            => bitspan_check<N7,ulong>();

        public void bitspan_8x64()
            => bitspan_check<N8,ulong>();

        public void bitspan_9x64()
            => bitspan_check<N9,ulong>();

        public void bitspan_10x64()
            => bitspan_check<N10,ulong>();

        public void bitspan_11x64()
            => bitspan_check<N11,ulong>();

        public void bitspan_12x64()
            => bitspan_check<N12,ulong>();

        public void bitspan_13x64()
            => bitspan_check<N13,ulong>();

        public void bitspan_14x64()
            => bitspan_check<N14,ulong>();

        public void bitspan_15x64()
            => bitspan_check<N15,ulong>();

        public void bitspan_16x64()
            => bitspan_check<N16,ulong>();

        public void bitspan_17x64()
            => bitspan_check<N17,ulong>();

        public void bitspan_18x64()
            => bitspan_check<N18,ulong>();

        public void bitspan_19x64()
            => bitspan_check<N19,ulong>();

        public void bitspan_20x64()
            => bitspan_check<N20,ulong>();

        public void bitspan_21x64()
            => bitspan_check<N21,ulong>();

        public void bitspan_22x64()
            => bitspan_check<N22,ulong>();

        public void bitspan_23x64()
            => bitspan_check<N23,ulong>();

        public void bitspan_24x64()
            => bitspan_check<N24,ulong>();

        public void bitspan_25x64()
            => bitspan_check<N25,ulong>();

        public void bitspan_26x64()
            => bitspan_check<N26,ulong>();

        public void bitspan_27x64()
            => bitspan_check<N27,ulong>();

        public void bitspan_28x64()
            => bitspan_check<N28,ulong>();

        public void bitspan_29x64()
            => bitspan_check<N29,ulong>();

        public void bitspan_30x64()
            => bitspan_check<N30,ulong>();

        public void bitspan_31x64()
            => bitspan_check<N31,ulong>();

        public void bitspan_32x64()
            => bitspan_check<N32,ulong>();

        public void bitspan_33x64()
            => bitspan_check<N33,ulong>();

        public void bitspan_34x64()
            => bitspan_check<N34,ulong>();

        public void bitspan_35x64()
            => bitspan_check<N35,ulong>();

        public void bitspan_36x64()
            => bitspan_check<N36,ulong>();

        public void bitspan_37x64()
            => bitspan_check<N37,ulong>();

        public void bitspan_38x64()
            => bitspan_check<N38,ulong>();

        public void bitspan_39x64()
            => bitspan_check<N39,ulong>();

        public void bitspan_40x64()
            => bitspan_check<N40,ulong>();
        
        public void bitspan_41x64()
            => bitspan_check<N41,ulong>();

        public void bitspan_42x64()
            => bitspan_check<N42,ulong>();

        public void bitspan_43x64()
            => bitspan_check<N43,ulong>();

        public void bitspan_44x64()
            => bitspan_check<N44,ulong>();

        public void bitspan_45x64()
            => bitspan_check<N45,ulong>();

        public void bitspan_46x64()
            => bitspan_check<N46,ulong>();

        public void bitspan_47x64()
            => bitspan_check<N47,ulong>();

        public void bitspan_48x64()
            => bitspan_check<N48,ulong>();

        public void bitspan_49x64()
            => bitspan_check<N49,ulong>();

        public void bitspan_50x64()
            => bitspan_check<N50,ulong>();

        public void bitspan_51x64()
            => bitspan_check<N51,ulong>();

        public void bitspan_52x64()
            => bitspan_check<N52,ulong>();

        public void bitspan_53x64()
            => bitspan_check<N53,ulong>();

        public void bitspan_54x64()
            => bitspan_check<N54,ulong>();

        public void bitspan_55x64()
            => bitspan_check<N55,ulong>();

        public void bitspan_56x64()
            => bitspan_check<N56,ulong>();

        public void bitspan_57x64()
            => bitspan_check<N57,ulong>();

        public void bitspan_58x64()
            => bitspan_check<N58,ulong>();

        public void bitspan_59x64()
            => bitspan_check<N59,ulong>();

        public void bitspan_60x64()
            => bitspan_check<N60,ulong>();

        public void bitspan_61x64()
            => bitspan_check<N61,ulong>();
        
        public void bitspan_62x64()
            => bitspan_check<N62,ulong>();

        public void bitspan_63x64()
            => bitspan_check<N63,ulong>();

        public void bitspan_64x64()
            => bitspan_check<N64,ulong>();
 
        protected void bitspan_check<N,T>(N n = default, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var length = (int)n.NatValue;
            for(var i=0; i< RepCount; i++)
            {
                var x = Random.BitVector<N,T>();
                var y = x.ToBitSpan();
                Claim.eq(natval<N>(), x.Width);
                Claim.eq(x.Width, y.Length);
                for(var j=0; j<length; j++)
                    Claim.eq(x[j],y[j]);                
            }           
        }

    }
}