//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using B = Quartet;

    /// <summary>
    /// Defines literals corresponding to the set of unique 4-bit sequences
    /// </summary>
    public enum Quartet : byte
    {
        b0000 = 0b0000,

        b0001 = 0b0001,

        b0010 = 0b0010,

        b0011 = 0b0011,

        b0100 = 0b0100,

        b0101 = 0b0101,

        b0110 = 0b0110,

        b0111 = 0b0111,

        b1000 = 0b1000,

        b1001 = 0b1001,

        b1010 = 0b1010,

        b1011 = 0b1011,

        b1100 = 0b1100,

        b1101 = 0b1101,

        b1110 = 0b1110,

        b1111 = 0b1111,

    }
    public partial class BitSets
    {
        public const B b0000 = B.b0000;
                
        public const B b0001 = B.b0001;

        public const B b0010 = B.b0010;

        public const B b0011 = B.b0011;

        public const B b0100 = B.b0100;

        public const B b0101 = B.b0101;

        public const B b0110 = B.b0110;

        public const B b0111 = B.b0111;

        public const B b1000 = B.b1000;

        public const B b1001 = B.b1001;

        public const B b1010 = B.b1010;

        public const B b1011 = B.b1011;

        public const B b1100 = B.b1100;

        public const B b1101 = B.b1101;

        public const B b1110 = B.b1110;

        public const B b1111 = B.b1111;
    }
}