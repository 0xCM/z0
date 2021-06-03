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

    public readonly struct BitFieldModel<T> : IBitfieldModel<T>
        where T : unmanaged
    {
        public StringAddress Name {get;}

        /// <summary>
        /// The number of defined segments
        /// </summary>
        public uint SectionCount {get;}

        /// <summary>
        /// The accumulated width of the defined segments
        /// </summary>
        public uint TotalWidth {get;}

        readonly Index<BitfieldSectionSpec<T>> _Sections;

        [MethodImpl(Inline)]
        public BitFieldModel(StringAddress name, Index<BitfieldSectionSpec<T>> sections)
        {
            Name = name;
            SectionCount = sections.Count;
            _Sections = sections;
            TotalWidth = 0;
            TotalWidth = BitfieldSpecs.width(this);
        }

        public ref BitfieldSectionSpec<T> this[uint i]
        {
            [MethodImpl(Inline)]
            get => ref _Sections[i];
        }

        public Span<BitfieldSectionSpec<T>> Sections
        {
            [MethodImpl(Inline)]
            get => _Sections.Edit;
        }

        [MethodImpl(Inline)]
        public uint Width(int index)
            => Section(index).Width;

        [MethodImpl(Inline)]
        public uint Position(int index)
            => bw32(Section(index).FirstIndex);

        [MethodImpl(Inline)]
        public ref BitfieldSectionSpec<T> Section(int index)
            => ref _Sections[index];
    }
}