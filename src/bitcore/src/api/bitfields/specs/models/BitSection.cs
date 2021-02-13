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
        public static implicit operator BitSection((ushort min, ushort max) src)
            => new BitSection(src.min, src.max);

        [MethodImpl(Inline)]
        public static implicit operator BitSection(Pair<ushort> src)
            => new BitSection(src.Left, src.Right);

        [MethodImpl(Inline)]
        public static implicit operator BitSection<uint>(BitSection src)
            => new BitSection(src.StartPos, src.EndPos);
    }
}