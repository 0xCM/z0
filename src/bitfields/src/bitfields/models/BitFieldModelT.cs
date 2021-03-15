//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public readonly struct BitFieldModel<T> : IBitFieldModel<T>
        where T : unmanaged
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

        readonly Index<BitSegment<T>> _Segments;

        [MethodImpl(Inline)]
        public BitFieldModel(Name name, uint count, uint width, Index<BitSegment<T>> segments)
        {
            Name = name;
            DataWidth = width;
            SegCount = count;
            _Segments = segments;
            TotalSegWidth = 0;
            TotalSegWidth = BitFields.width(this);
        }

        public ReadOnlySpan<BitSegment<T>> Segments
        {
            [MethodImpl(Inline)]
            get => _Segments.View;
        }

        [MethodImpl(Inline)]
        public uint Width(int index)
            => Segment(index).Width;

        [MethodImpl(Inline)]
        public uint Position(int index)
            => bw32(Segment(index).StartPos);

        [MethodImpl(Inline)]
        public ref readonly BitSegment<T> Segment(int index)
            => ref _Segments[index];
    }
}