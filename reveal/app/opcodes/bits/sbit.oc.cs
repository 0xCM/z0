//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.OpCodes
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    

    [OpCodeProvider]
    public static class sbits
    {
        public static void split_g64(ulong src, int index, out ulong x0, out ulong x1)
            => gbits.split(src, index, out x0, out x1);

        public static void split_64(ulong src, int index, out ulong x0, out ulong x1)
            => Bits.split(src, index, out x0, out x1);

        public static void split_exact(ulong src, out uint x0, out uint x1)
            => Bits.split(src, out x0, out x1);

        public static byte inject_8u(byte src, byte dst, int start, int len)
            => gbits.bitmap(src,dst,start,len);

        public static ushort inject_16u(ushort src, ushort dst, int start, int len)
            => gbits.bitmap(src,dst,start,len);

        public static uint inject_32u(uint src, uint dst, int start, int len)
            => gbits.bitmap(src,dst,start,len);

        public static ulong inject_64u(ulong src, ulong dst, int start, int len)
            => gbits.bitmap(src,dst,start,len);


        public static ulong pow2_20() => NatMath.pow2(n20);

        public static ulong pow2m1_20() => NatMath.pow2m1(n20);

        public static ulong pow2_33() => NatMath.pow2(n33);

        public static ulong pow2m1_33() => NatMath.pow2m1(n33);

        public static ulong pow2_1() => NatMath.pow2(n1);

        public static ulong pow2m1_1() => NatMath.pow2m1(n1);

        public static ulong pow2_2() => NatMath.pow2(n2);

        public static ulong pow2m1_2() => NatMath.pow2m1(n2);

        public static ulong pow2_3() => NatMath.pow2(n3);

        public static ulong pow2m1_3() => NatMath.pow2m1(n3);

        public static ulong pow2_4() => NatMath.pow2(n4);

        public static ulong pow2m1_4() => NatMath.pow2m1(n4);
        
        public static ulong pow2_5() => NatMath.pow2(n5);

        public static ulong pow2m1_5() => NatMath.pow2m1(n5);

        public static ulong pow2_6() => NatMath.pow2(n6);

        public static ulong pow2m1_6() => NatMath.pow2m1(n6);

        public static ulong pow2_7() => NatMath.pow2(n7);

        public static ulong pow2m1_7() => NatMath.pow2m1(n7);
    
        public static ulong pow2_8() => NatMath.pow2(n8);

        public static ulong pow2m1_8() => NatMath.pow2m1(n8);


        public static uint set_bit(uint src, byte pos, bit state)
            => gbits.set(src, pos, state);

        public static uint set_bit_nb(uint src, byte pos, bit state)
            => gbits.setnb(src, pos, state);

        public static uint set_bit_on(uint src, byte pos)
            => gbits.set(src, pos, bit.On);

        public static uint set_bit_off(uint src, byte pos)
            => gbits.set(src, pos, bit.Off);


    }

}