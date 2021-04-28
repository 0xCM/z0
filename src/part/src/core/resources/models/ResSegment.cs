//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ResSegment
    {
        public Name Name {get;}

        public MemSeg Segment {get;}

        [MethodImpl(Inline)]
        public ResSegment(Name name, in MemSeg segment)
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