//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct BitFieldModel
    {
        public readonly uint FieldCount;

        readonly TableSpan<BitFieldSegment> _Segments;

        [MethodImpl(Inline)]
        public BitFieldModel(uint count, uint width, BitFieldSegment[] segments)
        {
            FieldCount = count;
            _Segments = segments;
        }

        public ReadOnlySpan<BitFieldSegment> Segments
        {
            [MethodImpl(Inline)]
            get => _Segments.View;
        }

        [MethodImpl(Inline)]
        public uint Width(int index)
            => Segment(index).Width;

        [MethodImpl(Inline)]
        public uint Position(int index)
            => Segment(index).StartPos;

        [MethodImpl(Inline)]
        public ref readonly BitFieldSegment Segment(int index)
            => ref _Segments[index];
    }
}