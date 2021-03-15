//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    /// <summary>
    /// Represents a closed interval of bits from a data source operand and corresponds to the notation [max:min] or [min,max]
    /// </summary>
    public readonly struct BitFieldPart<T> : IBitFieldPart<T>
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
            get => BitFieldSpecs.width(this);
        }

        public BitFieldPart Untyped
        {
            [MethodImpl(Inline)]
            get => new BitFieldPart(Name, bw8(FirstIndex), bw8(LastIndex));
        }

        public string Format()
            => BitFieldSpecs.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator BitFieldPart(BitFieldPart<T> src)
            => src.Untyped;
    }
}