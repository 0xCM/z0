//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines a section within a bitfield that comprises one or more segments
    /// </summary>
    public readonly struct BitfieldSectionSpec : IBitfieldSectionSpec<uint>
    {
        /// <summary>
        /// The section name
        /// </summary>
        public StringAddress Name {get;}

        /// <summary>
        /// The index of the first bit in the section
        /// </summary>
        public uint FirstIndex {get;}

        /// <summary>
        /// The index of the last bit in the section
        /// </summary>
        public uint LastIndex {get;}

        public Index<BitfieldSegSpec> Segments {get;}

        [MethodImpl(Inline)]
        public BitfieldSectionSpec(StringAddress name, uint min, uint max, Index<BitfieldSegSpec> segments)
        {
            Name = name;
            FirstIndex = min;
            LastIndex = max;
            Segments = segments;
        }

        public ref BitfieldSegSpec this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Segments[index];
        }

        public byte Width
        {
            [MethodImpl(Inline)]
            get => (byte)(LastIndex - FirstIndex + 1);
        }


        [MethodImpl(Inline)]
        public static implicit operator BitfieldSectionSpec<uint>(BitfieldSectionSpec src)
            => new BitfieldSectionSpec(src.Name, src.FirstIndex, src.LastIndex, sys.empty<BitfieldSegSpec>());
    }
}