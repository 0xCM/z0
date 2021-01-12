//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ResourceSegment
    {
        public Name Name {get;}

        public MemorySegment Segment {get;}

        [MethodImpl(Inline)]
        public ResourceSegment(Name name, in MemorySegment segment)
        {
            Name = name;
            Segment = segment;
        }

        [MethodImpl(Inline)]
        public string Format()
            => string.Format("{0}[{1}:{2}]", Name, Segment.BaseAddress, Segment.Length);

        public override string ToString()
            => Format();
    }
}