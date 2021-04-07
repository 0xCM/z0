//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    // Open = '['
    // Close = ']'
    // SegSep = '|'
    // Bitfield = <FieldName> ':' Open (Seg [SegSep])* Close
    // Seg = <SegName> ':' Open <FirstPos> ',' <LastPos> Close
    // FirstPos = NonnegativeInteger
    // LastPos = PositiveInteger
    // MyField:[Part1:[0,3] | Part2:[4,5] | Part4:[6,17]]
    public readonly struct BitFieldModel : IBitFieldModel
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
        /// The width of the containing datatype
        /// </summary>
        public uint StorageWidth {get;}

        /// <summary>
        /// The accumulated width of the defined segments
        /// </summary>
        public uint SegmentWidth {get;}

        readonly Index<BitfieldPart> _Segments;

        [MethodImpl(Inline)]
        public BitFieldModel(Name name, uint count, uint width, Index<BitfieldPart> segments)
        {
            Name = name;
            StorageWidth = width;
            SegmentCount = count;
            _Segments = segments;
            SegmentWidth = 0;
            SegmentWidth = BitfieldSpecs.width(this);
        }

        public ReadOnlySpan<BitfieldPart> Segments
        {
            [MethodImpl(Inline)]
            get => _Segments.View;
        }

        [MethodImpl(Inline)]
        public uint Width(int index)
            => Segment(index).Width;

        [MethodImpl(Inline)]
        public uint Position(int index)
            => Segment(index).FirstIndex;

        [MethodImpl(Inline)]
        public ref readonly BitfieldPart Segment(int index)
            => ref _Segments[index];
    }
}