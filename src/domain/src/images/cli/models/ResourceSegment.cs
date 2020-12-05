//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ResourceSegment
    {
        public StringRef Name {get;}

        public MemorySegment Segment {get;}

        [MethodImpl(Inline)]
        public ResourceSegment(string name, in MemorySegment segment)
        {
            Name = name;
            Segment = segment;
        }

        [MethodImpl(Inline)]
        public string Format()
            => string.Format("{0}[{1}:{2}]", Name.Format(), Segment.Address, Segment.DataSize);

        public override string ToString()
            => Format();
    }
}