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
    using W = W256;

    public readonly struct W256 : IVectorWidth<W> 
    {
        public DW DataWidth => DW.W256; 

        public TW TypeWidth => TW.W256; 

        public FW FixedWidth => FW.W256; 

        public VW VectorWidth => VW.W256;

        [MethodImpl(Inline)]
        public static implicit operator int(W src)
            => (int)src.DataWidth;

        [MethodImpl(Inline)]
        public bool Equals(W w) => true;

        public override string ToString() 
            => DataWidth.FormatValue();
        
        public override int GetHashCode()
            => DataWidth.GetHashCode();
        
        public override bool Equals(object obj)
            => obj is W;
    }
}