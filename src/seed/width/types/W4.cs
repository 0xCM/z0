//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 4040
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static PartIdentity;
    
    using DW = DataWidth;
    using W = W4;

    public readonly struct W4 : IDataWidth<W> 
    { 
        public DW DataWidth => DW.W4; 

        [MethodImpl(Inline)]
        public static implicit operator int(W src) => (int)src.DataWidth;

        [MethodImpl(Inline)]
        public static implicit operator DW(W src) => src.DataWidth;

        [MethodImpl(Inline)]        
        public bool Equals(W w) => true;

        public override string ToString() => DataWidth.FormatValue();
        
        public override int GetHashCode() => DataWidth.GetHashCode();
        
        public override bool Equals(object obj) => obj is W;
    }
}