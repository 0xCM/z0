//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Defines a sequence of unique and sequential constants have been cleverly constructed to select
    /// a single selector-name correlated bit from a source value. Such constants are commonly known
    /// as powers-of-2
    /// </summary>
    public class BitSelectors
    {
        public const byte Bit0 = 0b1;

        public const byte Bit1 = 0b10;

        public const byte Bit2 = 0b100;

        public const byte Bit3 = 0b1000;

        public const byte Bit4 = 0b10000;

        public const byte Bit5 = 0b100000;

        public const byte Bit6 = 0b1000000;

        public const byte Bit7 = 0b10000000;

        public const ushort Bit8 = 0b100000000;

        public const ushort Bit9 = 0b1000000000;

        public const ushort Bit10 = 0b10000000000;

        public const ushort Bit11 = 0b100000000000;

        public const ushort Bit12 = 0b1000000000000;

        public const ushort Bit13 = 0b10000000000000;

        public const ushort Bit14 = 0b100000000000000;

        public const ushort Bit15 = 0b1000000000000000;

        public const uint Bit16 = 0b10000000000000000;

    }
}