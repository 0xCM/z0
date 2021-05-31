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
    /// Defines a section within a bitfield that comprises one or more segments
    /// </summary>
    public readonly struct BitfieldSectionSpec<T> : IBitfieldSectionSpec<T>
        where T : unmanaged
    {
        /// <summary>
        /// The section name
        /// </summary>
        public StringAddress Name {get;}

        /// <summary>
        /// The index, relative to the containing bitfield, of the first bit in the section
        /// </summary>
        public T FirstIndex {get;}

        /// <summary>
        /// The index, relative to the containing bitfield, of the last bit in the section
        /// </summary>
        public T LastIndex {get;}

        /// <summary>
        /// The segments within the section
        /// </summary>
        public Index<BitfieldSegSpec> Segments {get;}

        [MethodImpl(Inline)]
        public BitfieldSectionSpec(StringAddress name, T min, T max, Index<BitfieldSegSpec> segments)
        {
            Name = name;
            FirstIndex = min;
            LastIndex = max;
            Segments = segments;

        }

        public uint Width
        {
            [MethodImpl(Inline)]
            get => BitfieldSpecs.width(this);
        }

        public BitfieldSectionSpec Untyped
        {
            [MethodImpl(Inline)]
            get => new BitfieldSectionSpec(Name, bw32(FirstIndex), bw32(LastIndex), Segments);
        }


        [MethodImpl(Inline)]
        public static implicit operator BitfieldSectionSpec(BitfieldSectionSpec<T> src)
            => src.Untyped;
    }
}