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

    public struct BufferSegment
    {
        public ClosedInterval<uint> Range;

        [MethodImpl(Inline)]
        public BufferSegment(uint i0, uint i1)
        {
            Range = (i0,i1);
        }

        [MethodImpl(Inline)]
        public BufferSegment(in ClosedInterval<uint> range)
            => Range = range;

        [MethodImpl(Inline)]
        public string Format()
            => Range.Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator BufferSegment<byte>(BufferSegment src)
            => new BufferSegment<byte>(src.Range);

        [MethodImpl(Inline)]
        public static implicit operator BufferSegment<uint,byte>(BufferSegment src)
            => new BufferSegment<uint,byte>(src.Range);

        [MethodImpl(Inline)]
        public static implicit operator BufferSegment(BufferSegment<uint,byte> src)
            => new BufferSegment(src.Range);
    }
}