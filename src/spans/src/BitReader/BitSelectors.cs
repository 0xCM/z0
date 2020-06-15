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
        public const byte Bit0 = Pow2.T00;

        public const byte Bit1 = Pow2.T01;

        public const byte Bit2 = Pow2.T02;

        public const byte Bit3 = Pow2.T03;

        public const byte Bit4 = Pow2.T04;

        public const byte Bit5 = Pow2.T05;

        public const byte Bit6 = Pow2.T06;

        public const byte Bit7 = Pow2.T07;

        public const ushort Bit8 = 0b100000000;

        public const ushort Bit9 = 0b1000000000;

        public const ushort Bit10 = 0b10000000000;

        public const ushort Bit11 = 0b100000000000;

        public const ushort Bit12 = 0b1000000000000;

        public const ushort Bit13 = 0b10000000000000;

        public const ushort Bit14 = 0b100000000000000;

        public const ushort Bit15 = Pow2.T15;

        public const uint Bit16 = Pow2.T16;

        public const uint Bit17 = Pow2.T17;

        public const uint Bit18 = Pow2.T18;

        public const uint Bit19 = Pow2.T19;
    }
}