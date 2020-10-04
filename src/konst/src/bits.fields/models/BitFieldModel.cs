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
        readonly StringRef FieldName;

        public readonly uint FieldCount;

        readonly TableSpan<BitFieldSegment> _Segments;

        [MethodImpl(Inline)]
        public BitFieldModel(string name, uint count, uint width, BitFieldSegment[] segments)
        {
            FieldName = name;
            FieldCount = count;
            _Segments = segments;
        }

        public string BitFieldName
        {
            [MethodImpl(Inline)]
            get => FieldName;
        }

        public ReadOnlySpan<BitFieldSegment> Segments
        {
            [MethodImpl(Inline)]
            get => _Segments.View;
        }

        [MethodImpl(Inline)]
        public byte Width(int index)
            => Segment(index).Width;

        [MethodImpl(Inline)]
        public string Name(int index)
            => Segment(index).Name;

        [MethodImpl(Inline)]
        public uint Position(int index)
            => Segment(index).StartPos;

        [MethodImpl(Inline)]
        public ref readonly BitFieldSegment Segment(int index)
            => ref _Segments[index];
    }
}