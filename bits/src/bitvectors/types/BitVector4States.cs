//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Numerics;

    using static zfunc;
    using static Bits;
    using static Bytes;

    public static class BitVector4States
    {
        static readonly bit off = bit.Off;

        static readonly bit on = bit.On;

        public static readonly BitVector4 b0 = BitVector4.FromBit(off);

        public static readonly BitVector4 b1 = BitVector4.FromBit(on);

        public static readonly BitVector4 b00 = BitVector4.FromBits(off, off);

        public static readonly BitVector4 b01 = BitVector4.FromBits(on, off);

        public static readonly BitVector4 b10 = BitVector4.FromBits(off, on);

        public static readonly BitVector4 b11 = BitVector4.FromBits(on, on);

        public static readonly BitVector4 b000 = BitVector4.FromBits(off, off, off);

        public static readonly BitVector4 b001 = BitVector4.FromBits(on, off, off);

        public static readonly BitVector4 b010 = BitVector4.FromBits(off, on, off);

        public static readonly BitVector4 b011 = BitVector4.FromBits(on, on, off);

        public static readonly BitVector4 b100 = BitVector4.FromBits(off, off, on);

        public static readonly BitVector4 b101 = BitVector4.FromBits(on, off, on);

        public static readonly BitVector4 b110 = BitVector4.FromBits(off, on, on);

        public static readonly BitVector4 b111 = BitVector4.FromBits(on, on, on);

        public static readonly BitVector4 b0000 = BitVector4.FromBits(off, off, off, off);

        public static readonly BitVector4 b0001 = BitVector4.FromBits(on, off, off, off);

        public static readonly BitVector4 b0010 = BitVector4.FromBits(off, on, off, off);

        public static readonly BitVector4 b0011 = BitVector4.FromBits(on, on, off, off);

        public static readonly BitVector4 b0100 = BitVector4.FromBits(off, off, on, off);

        public static readonly BitVector4 b0101 = BitVector4.FromBits(on, off, on, off);

        public static readonly BitVector4 b0110 = BitVector4.FromBits(off, on, on, off);

        public static readonly BitVector4 b0111 = BitVector4.FromBits(on, on, on, off);

        public static readonly BitVector4 b1000 = BitVector4.FromBits(off, off, off, on);

        public static readonly BitVector4 b1001 = BitVector4.FromBits(on, off, off, on);

        public static readonly BitVector4 b1010 = BitVector4.FromBits(off, on, off, on);

        public static readonly BitVector4 b1011 = BitVector4.FromBits(on, on, off, on);

        public static readonly BitVector4 b1100 = BitVector4.FromBits(off, off, on, on);

        public static readonly BitVector4 b1101 = BitVector4.FromBits(on, off, on, on);

        public static readonly BitVector4 b1110 = BitVector4.FromBits(off, on, on, on);

        public static readonly BitVector4 b1111 = BitVector4.FromBits(on, on, on, on);


    }

}