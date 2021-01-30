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

        [MethodImpl(Inline)]
        public static implicit operator BitSection((ushort min, ushort max) src)
            => new BitSection(src.min, src.max);

        [MethodImpl(Inline)]
        public static implicit operator BitSection(Pair<ushort> src)
            => new BitSection(src.Left, src.Right);
    }

    /// <summary>
    /// Represents a closed interval of bits from a data source operand and corresponds to the notation [max:min] or [min,max]
    /// </summary>
    public readonly struct BitSection<T> : IBitSection<T>
        where T : unmanaged
    {
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
            StartPos = min;
            EndPos = max;
        }

        public uint Width
        {
            [MethodImpl(Inline)]
            get => width(this);
        }

        public string Format()
            => format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator BitSection<T>((T min, T max) src)
            => new BitSection<T>(src.min, src.max);

        [MethodImpl(Inline)]
        public static implicit operator BitSection<T>(Pair<T> src)
            => new BitSection<T>(src.Left, src.Right);

        [MethodImpl(Inline)]
        public static implicit operator BitSection<T>(ClosedInterval<T> src)
            => new BitSection<T>(src.Min, src.Max);
    }
}