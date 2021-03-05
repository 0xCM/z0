//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static BitSections;

    /// <summary>
    /// Represents a closed interval of bits from a data source operand and corresponds to the notation [max:min] or [min,max]
    /// </summary>
    public readonly struct BitSection<T> : IBitSection<T>
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
        public BitSection(T min, T max)
        {
            Name = EmptyString;
            StartPos = min;
            EndPos = max;
        }

        [MethodImpl(Inline)]
        public BitSection(Identifier name, T min, T max)
        {
            Name = name;
            StartPos = min;
            EndPos = max;
        }

        public uint Width
        {
            [MethodImpl(Inline)]
            get => width(this);
        }

        public BitSection Untyped
        {
            [MethodImpl(Inline)]
            get => new BitSection(Name, memory.u32(StartPos), memory.u32(EndPos));
        }

        public string Format()
            => format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator BitSection(BitSection<T> src)
            => src.Untyped;
    }
}