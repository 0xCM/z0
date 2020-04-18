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
    using VW = VectorWidth;
    using W = W128;

    public readonly struct W128 : IVectorWidth<W> 
    {
        public DW DataWidth => DW.W128; 

        public FW FixedWidth => FW.W128; 

        public TW TypeWidth => TW.W128; 

        public VW VectorWidth => VW.W128;

        [MethodImpl(Inline)]
        public static implicit operator int(W src) => (int)src.DataWidth;

        [MethodImpl(Inline)]
        public static implicit operator DW(W src) => src.DataWidth;

        [MethodImpl(Inline)]
        public static implicit operator FW(W src) => src.FixedWidth;

        [MethodImpl(Inline)]
        public static implicit operator TW(W src) => src.TypeWidth;

        [MethodImpl(Inline)]
        public static implicit operator VW(W src) => src.VectorWidth;

        [MethodImpl(Inline)]
        public bool Equals(W w) => true;

        public override string ToString() => DataWidth.FormatValue();
        
        public override int GetHashCode() => DataWidth.GetHashCode();
        
        public override bool Equals(object obj) => obj is W;
    }
}