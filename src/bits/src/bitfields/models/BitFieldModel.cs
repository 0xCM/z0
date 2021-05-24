//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct BitFieldModel : IBitfieldModel
    {
        /// <summary>
        /// The bitfield name
        /// </summary>
        public Name Name {get;}

        /// <summary>
        /// The number of defined segments
        /// </summary>
        public uint SegmentCount {get;}

        /// <summary>
        /// The accumulated width of the defined segments
        /// </summary>
        public uint TotalWidth {get;}

        readonly Index<BitfieldPart> _Parts;

        [MethodImpl(Inline)]
        public BitFieldModel(Name name, uint count, uint width, Index<BitfieldPart> parts)
        {
            Name = name;
            SegmentCount = count;
            _Parts = parts;
            TotalWidth = width;
            TotalWidth = BitfieldSpecs.width(this);
        }

        public ReadOnlySpan<BitfieldPart> Parts
        {
            [MethodImpl(Inline)]
            get => _Parts.Edit;
        }

        [MethodImpl(Inline)]
        public uint Width(int index)
            => Segment(index).Width;

        [MethodImpl(Inline)]
        public uint Position(int index)
            => Segment(index).FirstIndex;

        [MethodImpl(Inline)]
        public ref BitfieldPart Segment(int index)
            => ref _Parts[index];
    }
}