//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    /// <summary>
    /// Represents a closed interval of bits from a data source operand and corresponds to the notation [max:min] or [min,max]
    /// </summary>
    public readonly struct BitFieldPart<T> : IBitfieldSegModel<T>
        where T : unmanaged
    {
        /// <summary>
        /// The section anme
        /// </summary>
        public Identifier Name {get;}

        /// <summary>
        /// The index of the first bit in the section
        /// </summary>
        public T FirstIndex {get;}

        /// <summary>
        /// The index of the last bit in the section
        /// </summary>
        public T LastIndex {get;}

        [MethodImpl(Inline)]
        public BitFieldPart(Identifier name, T min, T max)
        {
            Name = name;
            FirstIndex = min;
            LastIndex = max;
        }

        public uint Width
        {
            [MethodImpl(Inline)]
            get => BitfieldSpecs.width(this);
        }

        public BitfieldPart Untyped
        {
            [MethodImpl(Inline)]
            get => new BitfieldPart(Name, bw8(FirstIndex), bw8(LastIndex));
        }

        public string Format()
            => BitfieldSpecs.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator BitfieldPart(BitFieldPart<T> src)
            => src.Untyped;
    }
}