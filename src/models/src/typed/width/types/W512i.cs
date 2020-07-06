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
    
    using W = W512i;

    /// <summary>
    /// Defines a type-level representation of <see cref='DW.W512'/> with a <see cref='TS.Signed'/> classifier
    /// </summary>
    public readonly struct W512i : TVectorWidth<W> 
    {
        public const DW Width = DW.W512; 

        public const TS Sign = TS.Signed;

        /// <summary>
        /// An instance-level representative
        /// </summary>
        public static W W => default;

        /// <summary>
        /// The width identity
        /// </summary>
        public const string Identifier = "w512i";

        public string Id 
            => Identifier;

        public DW DataWidth 
            => Width;

        public FW FixedWidth 
            => (FW)Width;

        public TW TypeWidth 
            => (TW)Width;

        public VW VectorWidth 
            => (VW)Width;

        public TS TypeSign
            => Sign;

        [MethodImpl(Inline)]
        public static implicit operator int(W src) 
            => (int)Width;

        [MethodImpl(Inline)]
        public static implicit operator DW(W src) 
            => Width;

        [MethodImpl(Inline)]
        public static implicit operator DataWidth<W>(W src) 
            => default;

        [MethodImpl(Inline)]
        public static implicit operator FW(W src) 
            => (FW)Width;

        [MethodImpl(Inline)]
        public static implicit operator TW(W src) 
            => (TW)Width;

        [MethodImpl(Inline)]
        public static implicit operator VW(W src) 
            => (VW)Width;

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
            => obj is W;
    }
}