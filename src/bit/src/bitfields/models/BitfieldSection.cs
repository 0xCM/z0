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
    public readonly struct BitfieldSection : IBitfieldSection<uint>
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

        public Index<BitfieldSeg> Segments {get;}

        [MethodImpl(Inline)]
        public BitfieldSection(StringAddress name, uint min, uint max, Index<BitfieldSeg> segments)
        {
            Name = name;
            FirstIndex = min;
            LastIndex = max;
            Segments = segments;
        }

        public ref BitfieldSeg this[uint index]
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
        public static implicit operator BitfieldSection<uint>(BitfieldSection src)
            => new BitfieldSection(src.Name, src.FirstIndex, src.LastIndex, sys.empty<BitfieldSeg>());
    }
}