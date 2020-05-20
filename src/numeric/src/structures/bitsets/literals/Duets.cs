//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using B = Duet;

    /// <summary>
    /// Defines literals corresponding to the set of unique 2-bit sequences
    /// </summary>
    public enum Duet : byte
    {
        b00 = 0b00,

        b01 = 0b01,

        b10 = 0b10,

        b11 = 0b11,
    }

    public partial class BitSets
    {
        public const B b00 = B.b00;
                
        public const B b01 = B.b01;

        public const B b10 = B.b10;

        public const B b11 = B.b11;
    }
}