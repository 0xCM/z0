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

    public readonly struct ContentSegment<T,W>
        where W : unmanaged
    {
        public readonly T Id;
        
        public readonly Interval<W> Width;

        [MethodImpl(Inline)]
        public ContentSegment(T id, Interval<W> width)
        {
            Id = id;
            Width = width;
        }

        public W MinWidth
        {
            [MethodImpl(Inline)]
            get => Width.Left;
        }

        public W MaxWidth
        {
            [MethodImpl(Inline)]
            get => Width.Right;
        }
    }
}
