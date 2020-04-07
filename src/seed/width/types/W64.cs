//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    using DW = DataWidth;
    using TW = TypeWidth;
    using FW = FixedWidth;
    using NW = NumericWidth;

    public readonly struct W64 : INumericWidth<W64> 
    {
        public DW DataWidth => DW.W64; 

        public TW TypeWidth => TW.W64; 

        public FW FixedWidth => FW.W64; 

        public NW NumericWidth => NW.W64; 

        [MethodImpl(Inline)]
        public static implicit operator int(W64 src)
            => (int)src.DataWidth;

        [MethodImpl(Inline)]
        public bool Equals(W64 w) => true;
 
        public override string ToString() 
            => DataWidth.FormatValue();
        
        public override int GetHashCode()
            => DataWidth.GetHashCode();
         
        public override bool Equals(object obj)
            => obj is W64;
    }
}