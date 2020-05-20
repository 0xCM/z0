//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using B = Triad;

    /// <summary>
    /// Defines literals corresponding to the set of unique 3-bit sequences
    /// </summary>
    public enum Triad : byte
    {
        b000 = 0b000,

        b001 = 0b001,

        b010 = 0b010,

        b011 = 0b011,

        b100 = 0b100,

        b101 = 0b101,

        b110 = 0b110,

        b111 = 0b111,
    }        

    public partial class BitSets
    {
        public const B b000 = B.b000;
                
        public const B b001 = B.b001;

        public const B b010 = B.b010;

        public const B b011 = B.b011;

        public const B b100 = B.b100;

        public const B b101 = B.b101;

        public const B b110 = B.b110;

        public const B b111 = B.b111;
    }
}