//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = BitFieldSpecs;

    /// <summary>
    /// Represents a closed interval of bits from a data source operand and corresponds to the notation [max:min] or [min,max]
    /// </summary>
    public readonly struct BitFieldPart : IBitFieldPart<byte>
    {
        /// <summary>
        /// The section anme
        /// </summary>
        public Identifier Name {get;}

        /// <summary>
        /// The index of the first bit in the section
        /// </summary>
        public byte FirstIndex {get;}

        /// <summary>
        /// The index of the last bit in the section
        /// </summary>
        public byte LastIndex {get;}

        [MethodImpl(Inline)]
        public BitFieldPart(Identifier name, byte min, byte max)
        {
            Name = name;
            FirstIndex = min;
            LastIndex = max;
        }

        public byte Width
        {
            [MethodImpl(Inline)]
            get => (byte)(LastIndex - FirstIndex + 1);
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator BitFieldPart<byte>(BitFieldPart src)
            => new BitFieldPart(src.Name, src.FirstIndex, src.LastIndex);
    }
}