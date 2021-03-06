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
        public Name Name {get;}

        /// <summary>
        /// The number of defined segments
        /// </summary>
        public uint SegCount {get;}

        /// <summary>
        /// The width of the containing datatype
        /// </summary>
        public uint DataWidth {get;}

        /// <summary>
        /// The accumulated width of the defined segments
        /// </summary>
        public uint TotalSegWidth {get;}

        readonly Index<BitSegment> Data;

        [MethodImpl(Inline)]
        public BitFieldModel(Name name, uint count, uint width, Index<BitSegment> segments)
        {
            Name = name;
            DataWidth = width;
            SegCount = count;
            Data = segments;
            TotalSegWidth = 0;
            TotalSegWidth = BitFieldModels.segwidth(this);
        }

        public ReadOnlySpan<BitSegment> Segments
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        [MethodImpl(Inline)]
        public uint Width(int index)
            => Segment(index).Width;

        [MethodImpl(Inline)]
        public uint Position(int index)
            => Segment(index).StartPos;

        [MethodImpl(Inline)]
        public ref readonly BitSegment Segment(int index)
            => ref Data[index];
    }
}