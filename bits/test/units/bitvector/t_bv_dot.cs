//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static BitVector;

    /// <summary>
    /// Verifies the correct function of the natural bitvector dot product operator
    /// </summary>
    public class t_bv_dot : t_bv<t_bv_dot>
    {
        public void nbv_dot_87x128x64()
            => nbv_dot_check_128<N87,ulong>();

        public void nbv_dot_2x8()
            => nbv_dot_check<N2,byte>();

        public void nbv_dot_3x8()
            => nbv_dot_check<N3,byte>();

        public void nbv_dot_4x8()
            => nbv_dot_check<N4,byte>();

        public void nbv_dot_5x8()
            => nbv_dot_check<N5,byte>();

        public void nbv_dot_6x8()
            => nbv_dot_check<N6,byte>();

        public void nbv_dot_7x8()
            => nbv_dot_check<N7,byte>();

        public void nbv_dot_8x8()
            => nbv_dot_check<N8,byte>();

        public void nbv_dot_2x16()
            => nbv_dot_check<N2,ushort>();

        public void nbv_dot_3x16()
            => nbv_dot_check<N3,ushort>();

        public void nbv_dot_4x16()
            => nbv_dot_check<N4,ushort>();

        public void nbv_dot_5x16()
            => nbv_dot_check<N5,ushort>();

        public void nbv_dot_6x16()
            => nbv_dot_check<N6,ushort>();

        public void nbv_dot_7x16()
            => nbv_dot_check<N7,ushort>();

        public void nbv_dot_8x16()
            => nbv_dot_check<N8,ushort>();

        public void nbv_dot_9x16()
            => nbv_dot_check<N9,ushort>();

        public void nbv_dot_10x16()
            => nbv_dot_check<N10,ushort>();

        public void nbv_dot_11x16()
            => nbv_dot_check<N11,ushort>();

        public void nbv_dot_12x16()
            => nbv_dot_check<N12,ushort>();

        public void nbv_dot_13x16()
            => nbv_dot_check<N13,ushort>();

        public void nbv_dot_14x16()
            => nbv_dot_check<N14,ushort>();

        public void nbv_dot_15x16()
            => nbv_dot_check<N15,ushort>();

        public void nbv_dot_16x16()
            => nbv_dot_check<N16,ushort>();

        public void nbv_dot_2x32()
            => nbv_dot_check<N2,uint>();

        public void nbv_dot_3x32()
            => nbv_dot_check<N3,uint>();

        public void nbv_dot_4x32()
            => nbv_dot_check<N4,uint>();

        public void nbv_dot_5x32()
            => nbv_dot_check<N5,uint>();

        public void nbv_dot_6x32()
            => nbv_dot_check<N6,uint>();

        public void nbv_dot_7x32()
            => nbv_dot_check<N7,uint>();

        public void nbv_dot_8x32()
            => nbv_dot_check<N8,uint>();

        public void nbv_dot_9x32()
            => nbv_dot_check<N9,uint>();

        public void nbv_dot_10x32()
            => nbv_dot_check<N10,uint>();

        public void nbv_dot_11x32()
            => nbv_dot_check<N11,uint>();

        public void nbv_dot_12x32()
            => nbv_dot_check<N12,uint>();

        public void nbv_dot_13x32()
            => nbv_dot_check<N13,uint>();

        public void nbv_dot_14x32()
            => nbv_dot_check<N14,uint>();

        public void nbv_dot_15x32()
            => nbv_dot_check<N15,uint>();

        public void nbv_dot_16x32()
            => nbv_dot_check<N16,uint>();

        public void nbv_dot_17x32()
            => nbv_dot_check<N17,uint>();

        public void nbv_dot_18x32()
            => nbv_dot_check<N18,uint>();

        public void nbv_dot_19x32()
            => nbv_dot_check<N19,uint>();

        public void nbv_dot_20x32()
            => nbv_dot_check<N20,uint>();

        public void nbv_dot_21x32()
            => nbv_dot_check<N21,uint>();

        public void nbv_dot_22x32()
            => nbv_dot_check<N22,uint>();

        public void nbv_dot_23x32()
            => nbv_dot_check<N23,uint>();

        public void nbv_dot_24x32()
            => nbv_dot_check<N24,uint>();

        public void nbv_dot_25x32()
            => nbv_dot_check<N25,uint>();

        public void nbv_dot_26x32()
            => nbv_dot_check<N26,uint>();

        public void nbv_dot_27x32()
            => nbv_dot_check<N27,uint>();

        public void nbv_dot_28x32()
            => nbv_dot_check<N28,uint>();

        public void nbv_dot_29x32()
            => nbv_dot_check<N29,uint>();

        public void nbv_dot_30x32()
            => nbv_dot_check<N30,uint>();

        public void nbv_dot_31x32()
            => nbv_dot_check<N31,uint>();

        public void nbv_dot_32x32()
            => nbv_dot_check<N32,uint>();

        public void nbv_dot_2x64()
            => nbv_dot_check<N2,ulong>();

        public void nbv_dot_3x64()
            => nbv_dot_check<N3,ulong>();

        public void nbv_dot_4x64()
            => nbv_dot_check<N4,ulong>();

        public void nbv_dot_5x64()
            => nbv_dot_check<N5,ulong>();

        public void nbv_dot_6x64()
            => nbv_dot_check<N6,ulong>();

        public void nbv_dot_7x64()
            => nbv_dot_check<N7,ulong>();

        public void nbv_dot_8x64()
            => nbv_dot_check<N8,ulong>();

        public void nbv_dot_9x64()
            => nbv_dot_check<N9,ulong>();

        public void nbv_dot_10x64()
            => nbv_dot_check<N10,ulong>();

        public void nbv_dot_11x64()
            => nbv_dot_check<N11,ulong>();

        public void nbv_dot_12x64()
            => nbv_dot_check<N12,ulong>();

        public void nbv_dot_13x64()
            => nbv_dot_check<N13,ulong>();

        public void nbv_dot_14x64()
            => nbv_dot_check<N14,ulong>();

        public void nbv_dot_15x64()
            => nbv_dot_check<N15,ulong>();

        public void nbv_dot_16x64()
            => nbv_dot_check<N16,ulong>();

        public void nbv_dot_17x64()
            => nbv_dot_check<N17,ulong>();

        public void nbv_dot_18x64()
            => nbv_dot_check<N18,ulong>();

        public void nbv_dot_19x64()
            => nbv_dot_check<N19,ulong>();

        public void nbv_dot_20x64()
            => nbv_dot_check<N20,ulong>();

        public void nbv_dot_21x64()
            => nbv_dot_check<N21,ulong>();

        public void nbv_dot_22x64()
            => nbv_dot_check<N22,ulong>();

        public void nbv_dot_23x64()
            => nbv_dot_check<N23,ulong>();

        public void nbv_dot_24x64()
            => nbv_dot_check<N24,ulong>();

        public void nbv_dot_25x64()
            => nbv_dot_check<N25,ulong>();

        public void nbv_dot_26x64()
            => nbv_dot_check<N26,ulong>();

        public void nbv_dot_27x64()
            => nbv_dot_check<N27,ulong>();

        public void nbv_dot_28x64()
            => nbv_dot_check<N28,ulong>();

        public void nbv_dot_29x64()
            => nbv_dot_check<N29,ulong>();

        public void nbv_dot_30x64()
            => nbv_dot_check<N30,ulong>();

        public void nbv_dot_31x64()
            => nbv_dot_check<N31,ulong>();

        public void nbv_dot_32x64()
            => nbv_dot_check<N32,ulong>();

        public void nbv_dot_33x64()
            => nbv_dot_check<N33,ulong>();

        public void nbv_dot_34x64()
            => nbv_dot_check<N34,ulong>();

        public void nbv_dot_35x64()
            => nbv_dot_check<N35,ulong>();

        public void nbv_dot_36x64()
            => nbv_dot_check<N36,ulong>();

        public void nbv_dot_37x64()
            => nbv_dot_check<N37,ulong>();

        public void nbv_dot_38x64()
            => nbv_dot_check<N38,ulong>();

        public void nbv_dot_39x64()
            => nbv_dot_check<N39,ulong>();

        public void nbv_dot_40x64()
            => nbv_dot_check<N40,ulong>();
        
        public void nbv_dot_41x64()
            => nbv_dot_check<N41,ulong>();

        public void nbv_dot_42x64()
            => nbv_dot_check<N42,ulong>();

        public void nbv_dot_43x64()
            => nbv_dot_check<N43,ulong>();

        public void nbv_dot_44x64()
            => nbv_dot_check<N44,ulong>();

        public void nbv_dot_45x64()
            => nbv_dot_check<N45,ulong>();

        public void nbv_dot_46x64()
            => nbv_dot_check<N46,ulong>();

        public void nbv_dot_47x64()
            => nbv_dot_check<N47,ulong>();

        public void nbv_dot_48x64()
            => nbv_dot_check<N48,ulong>();

        public void nbv_dot_49x64()
            => nbv_dot_check<N49,ulong>();

        public void nbv_dot_50x64()
            => nbv_dot_check<N50,ulong>();

        public void nbv_dot_51x64()
            => nbv_dot_check<N51,ulong>();

        public void nbv_dot_52x64()
            => nbv_dot_check<N52,ulong>();

        public void nbv_dot_53x64()
            => nbv_dot_check<N53,ulong>();

        public void nbv_dot_54x64()
            => nbv_dot_check<N54,ulong>();

        public void nbv_dot_55x64()
            => nbv_dot_check<N55,ulong>();

        public void nbv_dot_56x64()
            => nbv_dot_check<N56,ulong>();

        public void nbv_dot_57x64()
            => nbv_dot_check<N57,ulong>();

        public void nbv_dot_58x64()
            => nbv_dot_check<N58,ulong>();

        public void nbv_dot_59x64()
            => nbv_dot_check<N59,ulong>();

        public void nbv_dot_60x64()
            => nbv_dot_check<N60,ulong>();

        public void nbv_dot_61x64()
            => nbv_dot_check<N61,ulong>();
        
        public void nbv_dot_62x64()
            => nbv_dot_check<N62,ulong>();

        public void nbv_dot_63x64()
            => nbv_dot_check<N63,ulong>();

        public void nbv_dot_64x64()
            => nbv_dot_check<N64,ulong>();
 
         public void gbv_dot_8()
            => gbv_dot_check<byte>();

        public void gbv_dot_16()
            => gbv_dot_check<ushort>();

        public void gbv_dot_32()
            => gbv_dot_check<uint>();

        public void gbv_dot_64()
            => gbv_dot_check<ulong>();


        public void pbv_dot_4()
        {
            for(var i=0; i<SampleCount; i++)
            {
                var x = Random.BitVector(n4);
                var y = Random.BitVector(n4);
                var a = x % y;
                var b = modprod(x,y);
                Claim.yea(a == b);            
            }
        }

        public void pbv_dot_8()
        {
            for(var i=0; i<SampleCount; i++)
            {
                var x = Random.BitVector(n8);
                var y = Random.BitVector(n8);
                var a = x % y;
                var b = modprod(x,y);
                Claim.yea(a == b);            

                var zx = x.ToBitCells();
                var zy = y.ToBitCells();
                var c = zx % zy;
                Claim.yea(a == c);
            }            
        }

        public void pbv_dot_16()
        {
            for(var i=0; i<SampleCount; i++)
            {
                var x = Random.BitVector(n16);
                var y = Random.BitVector(n16);
                var a = x % y;
                var b = modprod(x,y);
                Claim.yea(a == b);   

                var zx = x.ToBitCells();
                var zy = y.ToBitCells();
                var c = zx % zy;
                Claim.yea(a == c);

            }
        }

        public void pbv_dot_32()
        {
            for(var i=0; i<SampleCount; i++)
            {
                var x = Random.BitVector(n32);
                var y = Random.BitVector(n32);
                var a = x % y;
                var b = modprod(x,y);
                Claim.yea(a == b);   

                var zx = x.ToNatural();
                var zy = y.ToNatural();
                var c = zx % zy;
                Claim.yea(a == c);

            }
        }

        public void pbv_dot_64()
        {
            for(var i=0; i<SampleCount; i++)
            {
                var x = Random.BitVector(n64);
                var y = Random.BitVector(n64);
                bit a = x % y;
                var b = modprod(x,y);
                Claim.yea(a == b);

                var zx = x.ToBitCells();
                var zy = y.ToBitCells();
                bit c = zx % zy;
                Claim.yea(a == c);            
            }

            for(var i=0; i< SampleCount; i++)          
            {
                var x32 = Random.BitVector(n32);
                var y32 = Random.BitVector(n32);
                var dot32 = BitVector.dot(x32,y32);
                var x64 = x32.Expand(n64);
                var y64 = y32.Expand(n64);
                var dot64 = BitVector.dot(x64,y64);
                Claim.eq(dot32,dot64);
            }
        }
    }
}