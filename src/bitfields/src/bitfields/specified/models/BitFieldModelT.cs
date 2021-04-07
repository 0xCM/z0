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
        public uint SegmentCount {get;}

        /// <summary>
        /// The width of the containing datatype
        /// </summary>
        public uint StorageWidth {get;}

        /// <summary>
        /// The accumulated width of the defined segments
        /// </summary>
        public uint SegmentWidth {get;}

        readonly Index<BitFieldPart<T>> _Segments;

        [MethodImpl(Inline)]
        public BitFieldModel(Name name, uint count, uint width, Index<BitFieldPart<T>> segments)
        {
            Name = name;
            StorageWidth = width;
            SegmentCount = count;
            _Segments = segments;
            SegmentWidth = 0;
            SegmentWidth = BitfieldSpecs.width(this);
        }

        public ReadOnlySpan<BitFieldPart<T>> Segments
        {
            [MethodImpl(Inline)]
            get => _Segments.View;
        }

        [MethodImpl(Inline)]
        public uint Width(int index)
            => Segment(index).Width;

        [MethodImpl(Inline)]
        public uint Position(int index)
            => bw32(Segment(index).FirstIndex);

        [MethodImpl(Inline)]
        public ref readonly BitFieldPart<T> Segment(int index)
            => ref _Segments[index];
    }
}