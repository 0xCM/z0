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
    public readonly struct BitSegment<T> : IBitSegment<T>
        where T : unmanaged
    {
        /// <summary>
        /// The section anme
        /// </summary>
        public Identifier Name {get;}

        /// <summary>
        /// The index of the first bit in the section
        /// </summary>
        public T StartPos {get;}

        /// <summary>
        /// The index of the last bit in the section
        /// </summary>
        public T EndPos {get;}

        [MethodImpl(Inline)]
        public BitSegment(Identifier name, T min, T max)
        {
            Name = name;
            StartPos = min;
            EndPos = max;
        }

        public uint Width
        {
            [MethodImpl(Inline)]
            get => BitFields.width(this);
        }

        public BitSegment Untyped
        {
            [MethodImpl(Inline)]
            get => new BitSegment(Name, bw8(StartPos), bw8(EndPos));
        }

        public string Format()
            => BitFields.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator BitSegment(BitSegment<T> src)
            => src.Untyped;
    }
}