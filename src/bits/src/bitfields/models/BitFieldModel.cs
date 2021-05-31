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

        readonly Index<BitfieldSectionSpec> _Sections;

        [MethodImpl(Inline)]
        public BitfieldModel(StringAddress name, Index<BitfieldSectionSpec> sections)
        {
            Name = name;
            SectionCount = sections.Count;
            _Sections = sections;
            TotalWidth = 0;
            TotalWidth = BitfieldSpecs.width(this);
        }

        public Span<BitfieldSectionSpec> Sections
        {
            [MethodImpl(Inline)]
            get => _Sections.Edit;
        }

        [MethodImpl(Inline)]
        public ref BitfieldSectionSpec Section(uint i)
            => ref _Sections[i];

        [MethodImpl(Inline)]
        public ref BitfieldSegSpec Segment(uint i, uint j)
            => ref _Sections[i][j];

        public ref BitfieldSectionSpec this[uint i]
        {
            [MethodImpl(Inline)]
            get => ref Section(i);
        }

        public ref BitfieldSegSpec this[uint i, uint j]
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
            => this[i,j].FirstIndex;

        [MethodImpl(Inline)]
        public uint SegEnd(uint i, uint j)
            => this[i,j].LastIndex;
    }
}