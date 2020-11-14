//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public ref struct BufferSequence<T>
    {
        readonly Span<T> Data;

        readonly Span<BufferSegment<byte,T>> Segments;

        public BufferSequence(Span<T> data)
        {
            Data = data;
            Segments = z.alloc<BufferSegment<byte,T>>(byte.MaxValue);
        }

        [MethodImpl(Inline)]
        public ref BufferSegment<byte,T> Segment(byte index)
            => ref z.seek(Segments, index);

        [MethodImpl(Inline)]
        public Span<T> Buffer(byte index)
        {
            ref readonly var segment = ref Segment(index);
            return z.slice(Data, segment.I0, segment.Length);
        }
    }
}