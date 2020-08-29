//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [Table]
    public struct MemberString
    {
        public static ReadOnlySpan<byte> RenderWidths
            => new byte[4]{10, 12, 12, 64};

        public Sequential<int> Sequence;

        public Address32 Offset;

        public ByteSize HeapSize;

        public string Content;
    }
}