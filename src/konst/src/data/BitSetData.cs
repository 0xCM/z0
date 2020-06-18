//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct BitSetData
    {
        public static ReadOnlySpan<byte> Singletons
            => new byte[2]{0b00,0b01};

        public static ReadOnlySpan<byte> Duets
            => new byte[4]{0b00,0b01,0b10,0b11};
 
        public static ReadOnlySpan<byte> Triads
            => new byte[8]{0b000,0b001,0b010,0b011,0b100,0b101,0b110,0b111};

        public static ReadOnlySpan<byte> Quartets
            => new byte[16]{
                0b0000,0b0001,0b0010,0b0011,0b0100,0b0101,0b0110,0b0111,
                0b1000,0b1001,0b1010,0b1011,0b1100,0b1101,0b1110,0b1111,
                };

        public static ReadOnlySpan<byte> Quintets
            => new byte[32]{
                0b00000,0b00001,0b00010,0b00011,0b00100,0b00101,0b00110,0b00111,
                0b01000,0b01001,0b01010,0b01011,0b01100,0b01101,0b01110,0b01111,
                0b10000,0b10001,0b10010,0b10011,0b10100,0b10101,0b10110,0b10111,
                0b11000,0b11001,0b11010,0b11011,0b11100,0b11101,0b11110,0b11111,
                };

    }
}