//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;
    using static As;
    using static AsIn;

    public static class bitmaskoc
    {            

        public static Vector128<byte> makemask_128x8u(BitVector16 src)
            => dinx.vmakemask(src);

        public static Vector128<byte> makemask_128x8u_literal()
            => dinx.vmakemask(0xFCFC);

        public static Vector256<byte> makemask_256x8u(BitVector32 src)
            => dinx.vmakemask(src);

        public static Vector256<byte> makemask_256x8u_literal()
            => dinx.vmakemask(0xF0F0F0C0u);

        public static Vector128<byte> makemask_g128x8u(BitVector16 src)
            => ginx.vmakemask<byte>(src);

        public static Vector128<ushort> makemask_g128x16u(BitVector16 src)
            => ginx.vmakemask<ushort>(src);

        public static Vector256<uint> makemask_g256x32u(BitVector32 src)
            => ginx.vmakemask<uint>(src);

        public static ulong lsb_64x8x3(ulong src)
            => BitMasks.lsb8x3(src);

        public static uint lsb_32x8x3(uint src)
            => BitMasks.lsb8x3(src);

        public static ushort lsb_16x8x3(ushort src)
            => BitMasks.lsb8x3(src);

        public static byte lsb_8x3(byte src)
            => BitMasks.lsb8x3(src);

        public static ulong mask_1x64u(int exp0)
            => Bits.mask(exp0);        

        public static ulong mask_2x64u(int exp0, int exp1)
            => Bits.mask(exp0, exp1);        

        public static ulong mask_3x64u(int exp0, int exp1, int exp2)
            => Bits.mask(exp0, exp1, exp2);        
        public static ulong mask_5x64u(int exp0, int exp1, int exp2, int exp3, int exp4)
            => Bits.mask(exp0, exp1, exp2, exp3, exp4);        

        public static ulong mask_6x64u(int exp0, int exp1, int exp2, int exp3, int exp4, int exp5)
            => Bits.mask(exp0, exp1, exp2, exp3, exp4, exp5);        

        public static ulong mask_7x64u(int exp0, int exp1, int exp2, int exp3, int exp4, int exp5, int exp6)
            => Bits.mask(exp0, exp1, exp2, exp3, exp4, exp5, exp6);        


        public static void set_bit(ref uint src, byte pos, bit state)
            => gbits.set(ref src, pos, state);

        public static void set_bit_on(ref uint src, byte pos)
            => gbits.set(ref src, pos, bit.On);

        public static void set_bit_off(ref uint src, byte pos)
            => gbits.set(ref src, pos, bit.Off);


    }
}