//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = BitFieldModels;

    /// <summary>
    /// Represents a closed interval of bits from a data source operand and corresponds to the notation [max:min] or [min,max]
    /// </summary>
    public readonly struct BitSection : IBitSection<uint>
    {
        /// <summary>
        /// The section anme
        /// </summary>
        public Identifier Name {get;}

        /// <summary>
        /// The index of the first bit in the section
        /// </summary>
        public uint StartPos {get;}

        /// <summary>
        /// The index of the last bit in the section
        /// </summary>
        public uint EndPos {get;}

        [MethodImpl(Inline)]
        public BitSection(uint min, uint max)
        {
            Name = EmptyString;
            StartPos = min;
            EndPos = max;
        }

        [MethodImpl(Inline)]
        public BitSection(Identifier name, uint min, uint max)
        {
            Name = name;
            StartPos = min;
            EndPos = max;
        }

        public uint Width
        {
            [MethodImpl(Inline)]
            get => EndPos - StartPos;
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator BitSection<uint>(BitSection src)
            => new BitSection(src.Name, src.StartPos, src.EndPos);
    }
}