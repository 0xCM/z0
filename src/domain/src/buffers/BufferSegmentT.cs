//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    /// <summary>
    /// Defines a segment over a buffer
    /// </summary>
    public struct BufferSegment<T> : ITextual
        where T : unmanaged
    {
        public ClosedInterval<uint> Range;

        [MethodImpl(Inline)]
        public BufferSegment(uint i0, uint i1)
            => Range = (i0,i1);

        [MethodImpl(Inline)]
        public BufferSegment(in ClosedInterval<uint> range)
            => Range = range;

        [MethodImpl(Inline)]
        public string Format()
            => Range.Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator BufferSegment<uint,T>(BufferSegment<T> src)
            => new BufferSegment<uint,T>(src.Range);

        [MethodImpl(Inline)]
        public static implicit operator BufferSegment<T>(BufferSegment<uint,T> src)
            => new BufferSegment<uint,T>(src.Range);
    }
}