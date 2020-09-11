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
    using FW = CellWidth;
    using NW = NumericWidth;
    using TS = TypeSignKind;

    using W = W16;

    /// <summary>
    /// Defines a type-level representation of <see cref='DW.W16'/>
    /// </summary>
    public readonly struct W16 : TNumericWidth<W>
    {
        public const DW Width = DW.W16;

        public const TS Sign = TS.Unsigned;

        /// <summary>
        /// An instance-level representative
        /// </summary>
        public static W W => default;

        /// <summary>
        /// The width identity
        /// </summary>
        public const string Identifier = "w16";

        public string Id
            => Identifier;

        public DW DataWidth
            => Width;

        public TS TypeSign
            => Sign;

        public FW CellWidth
            => (FW)Width;

        public TW TypeWidth
            => (TW)Width;

        public NW NumericWidth
            => (NW)Width;

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
        public static implicit operator TW(W src)
            => (TW)Width;

        [MethodImpl(Inline)]
        public static implicit operator FW(W src)
            => (FW)Width;

        [MethodImpl(Inline)]
        public static implicit operator NW(W src)
            => (NW)Width;

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