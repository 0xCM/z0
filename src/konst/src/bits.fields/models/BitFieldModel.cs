//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct BitFieldModel
    {
        public uint FieldCount {get;}

        readonly Index<BitFieldSegment> Data;

        [MethodImpl(Inline)]
        public BitFieldModel(uint count, uint width, BitFieldSegment[] segments)
        {
            FieldCount = count;
            Data = segments;
        }

        public ReadOnlySpan<BitFieldSegment> Segments
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
        public ref readonly BitFieldSegment Segment(int index)
            => ref Data[index];
    }
}