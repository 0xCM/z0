//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines a byte-parametric field segment
    /// </summary>
    public readonly struct BitFieldSegment : IBitFieldSegment<uint>
    {
        /// <summary>
        /// The segment name
        /// </summary>
        public Name Name {get;}

        /// <summary>
        /// The section over which the segment is defined
        /// </summary>
        public BitSection<uint> Section {get;}

        [MethodImpl(Inline)]
        public BitFieldSegment(Name name, BitSection section)
        {
            Name = name;
            Section = section;
        }

        [MethodImpl(Inline)]
        public BitFieldSegment(Name name, BitSection<uint> section)
        {
            Name = name;
            Section = section;
        }

        /// <summary>
        /// The segment bit-width
        /// </summary>
        public uint Width
        {
            [MethodImpl(Inline)]
            get => Section.Width;
        }

        public uint StartPos
        {
           [MethodImpl(Inline)]
           get => Section.StartPos;
        }

        public uint EndPos
        {
            [MethodImpl(Inline)]
            get => Section.EndPos;
        }

        [MethodImpl(Inline)]
        public static implicit operator BitFieldSegment<uint>(in BitFieldSegment src)
            => new BitFieldSegment<uint>(src.Name, src.Section);
    }
}