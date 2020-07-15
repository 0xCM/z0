//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static z;

    public readonly struct ContentSegment
    {
        public readonly StringRef Id;

        public readonly Interval<uint> Width;

        [MethodImpl(Inline)]
        public ContentSegment(StringRef id, Interval<uint> width)
        {
            Id = id;
            Width = width;
        }

        public uint MinWidth
        {
            [MethodImpl(Inline)]
            get => Width.Left;
        }

        public uint MaxWidth
        {
            [MethodImpl(Inline)]
            get => Width.Right;
        }
    }
}