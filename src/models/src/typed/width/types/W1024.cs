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
    using VW = VectorWidth;
    using TS = TypeSignKind;
    
    using W = W1024;

    /// <summary>
    /// Defines a type-level representation of <see cref='DW.W1024'/>
    /// </summary>
    public readonly struct W1024 : IFixedWidth<W> 
    {
        public const DW Width = DW.W1024; 

        public const TS Sign = TS.Unsigned;

        public DW DataWidth 
            => Width;

        public FW FixedWidth 
            => (FW)Width;

        public TW TypeWidth 
            => (TW)Width;

        public TS TypeSign
            => Sign;

        [MethodImpl(Inline)]
        public static implicit operator int(W src) 
            => (int)Width;

        [MethodImpl(Inline)]
        public static implicit operator DW(W src) 
            => Width;

        [MethodImpl(Inline)]
        public static implicit operator FW(W src) 
            => (FW)Width;

        [MethodImpl(Inline)]
        public static implicit operator TW(W src) 
            => (TW)Width;

        [MethodImpl(Inline)]
        public bool Equals(W w) 
            => true;

        public override string ToString() 
            => Width.FormatValue();
        
        public override int GetHashCode() 
            => (int)Width;

        public override bool Equals(object obj) 
            => obj is W;
    }
}