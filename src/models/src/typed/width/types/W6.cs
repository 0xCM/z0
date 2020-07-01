//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 6060
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    using DW = DataWidth;
    using TS = TypeSignKind;

    using W = W6;

    /// <summary>
    /// Defines a type-level representation of <see cref='DW.W6'/>
    /// </summary>
    public readonly struct W6 : IDataWidth<W> 
    { 
        public const DW Width = DW.W6; 

        public const TS Sign = TS.Unsigned;

        public DW DataWidth 
            => Width;

        public TS TypeSign
            => Sign;

        [MethodImpl(Inline)]
        public static implicit operator int(W src) 
            => (int)Width;

        [MethodImpl(Inline)]
        public static implicit operator DW(W src) 
            => Width;

        [MethodImpl(Inline)]        
        public bool Equals(W w) 
            => true;

        [MethodImpl(Inline)]
        public string Format()
            => Width.FormatValue();

        public override string ToString() 
            => Format();
        
        public override int GetHashCode() 
            => (int)Width;
        
        public override bool Equals(object obj) 
            => obj is W;    }
}