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

    public readonly struct W1024 : IFixedWidth<W1024> 
    {
        public DW DataWidth => DW.W1024;         

        public TW TypeWidth => TW.W1024; 

        public FW FixedWidth => FW.W1024; 

        [MethodImpl(Inline)]
        public static implicit operator int(W1024 src)
            => (int)src.DataWidth;

        [MethodImpl(Inline)]
        public bool Equals(W1024 w) => true;

        public override string ToString() 
            => DataWidth.FormatValue();
        
        public override int GetHashCode()
            => DataWidth.GetHashCode();

        public override bool Equals(object obj)
            => obj is W1024;
    }
}