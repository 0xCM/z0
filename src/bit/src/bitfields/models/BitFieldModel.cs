//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct BitfieldModel : IBitfieldModel
    {
        /// <summary>
        /// The bitfield name
        /// </summary>
        public StringAddress Name {get;}

        /// <summary>
        /// The number of defined segments
        /// </summary>
        public uint SectionCount {get;}

        /// <summary>
        /// The accumulated width of the defined segments
        /// </summary>
        public uint TotalWidth {get;}

        readonly Index<BitfieldSection> Data;

        [MethodImpl(Inline)]
        public BitfieldModel(StringAddress name, Index<BitfieldSection> sections)
        {
            Name = name;
            SectionCount = sections.Count;
            Data = sections;
            TotalWidth = 0;
            TotalWidth = BitfieldSpecs.width(this);
        }

        public Span<BitfieldSection> Sections
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        [MethodImpl(Inline)]
        public ref BitfieldSection Section(uint i)
            => ref Data[i];

        [MethodImpl(Inline)]
        public ref BitfieldSeg Segment(uint i, uint j)
            => ref Data[i][j];

        public ref BitfieldSection this[uint i]
        {
            [MethodImpl(Inline)]
            get => ref Section(i);
        }

        public ref BitfieldSeg this[uint i, uint j]
        {
            [MethodImpl(Inline)]
            get => ref Segment(i,j);
        }

        [MethodImpl(Inline)]
        public uint SectionWidth(uint i)
            => this[i].Width;

        [MethodImpl(Inline)]
        public uint SectionStart(uint i)
            => this[i].FirstIndex;

        [MethodImpl(Inline)]
        public uint SectionEnd(uint i)
            => this[i].LastIndex;

        [MethodImpl(Inline)]
        public uint SegWidth(uint i, uint j)
            => this[i,j].Width;

        [MethodImpl(Inline)]
        public uint SegStart(uint i, uint j)
            => this[i,j].Min;

        [MethodImpl(Inline)]
        public uint SegEnd(uint i, uint j)
            => this[i,j].Max;
    }
}