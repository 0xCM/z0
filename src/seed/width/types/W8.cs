//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    using DW = DataWidth;
    using TW = TypeWidth;
    using FW = FixedWidth;
    using NW = NumericWidth;
    using W = W8;

    public readonly struct W8 : INumericWidth<W> 
    { 
        public DW DataWidth => DW.W8; 

        public FW FixedWidth => FW.W8; 

        public TW TypeWidth => TW.W8; 

        public NW NumericWidth => NW.W8; 

        [MethodImpl(Inline)]
        public static implicit operator int(W src) => (int)src.DataWidth;

        [MethodImpl(Inline)]
        public static implicit operator DW(W src) => src.DataWidth;

        [MethodImpl(Inline)]
        public static implicit operator TW(W src) => src.TypeWidth;

        [MethodImpl(Inline)]
        public static implicit operator FW(W src) => src.FixedWidth;

        [MethodImpl(Inline)]
        public static implicit operator NW(W src) => src.NumericWidth;

        [MethodImpl(Inline)]        
        public bool Equals(W w) => true;

        public override string ToString() => DataWidth.FormatValue();
        
        public override int GetHashCode() => DataWidth.GetHashCode();
        
        public override bool Equals(object obj) => obj is W;
    }
}