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
    public struct BufferSegment<K,T> : ITextual
        where T : unmanaged
        where K : unmanaged
    {
        public ClosedInterval<K> Range;

        [MethodImpl(Inline)]
        public BufferSegment(K i0, K i1)
            => Range = (i0,i1);

        [MethodImpl(Inline)]
        public BufferSegment(in ClosedInterval<K> range)
            => Range = range;

        [MethodImpl(Inline)]
        public string Format()
            => Range.Format();

        public override string ToString()
            => Format();
    }
}