//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = BitFields;

    /// <summary>
    /// Represents a closed interval of bits from a data source operand and corresponds to the notation [max:min] or [min,max]
    /// </summary>
    public readonly struct BitSegment : IBitSegment<byte>
    {
        /// <summary>
        /// The section anme
        /// </summary>
        public Identifier Name {get;}

        /// <summary>
        /// The index of the first bit in the section
        /// </summary>
        public byte StartPos {get;}

        /// <summary>
        /// The index of the last bit in the section
        /// </summary>
        public byte EndPos {get;}

        [MethodImpl(Inline)]
        public BitSegment(Identifier name, byte min, byte max)
        {
            Name = name;
            StartPos = min;
            EndPos = max;
        }

        public byte Width
        {
            [MethodImpl(Inline)]
            get => (byte)(EndPos - StartPos + 1);
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator BitSegment<byte>(BitSegment src)
            => new BitSegment(src.Name, src.StartPos, src.EndPos);
    }
}