//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    using static Part;

    partial struct ImageRecords
    {
        public readonly struct GuidIndex : IHeapKey<GuidIndex>
        {
            public HeapKind HeapKind => HeapKind.Guid;

            public uint Value {get;}

            [MethodImpl(Inline)]
            public GuidIndex(uint value)
            {
                Value = value;
            }

            [MethodImpl(Inline)]
            public GuidIndex(GuidHandle value)
            {
                Value = memory.u32(value);
            }

            [MethodImpl(Inline)]
            public static implicit operator GuidIndex(GuidHandle src)
                => new GuidIndex(src);

            [MethodImpl(Inline)]
            public static implicit operator HeapKey(GuidIndex src)
                => new HeapKey(src.HeapKind, src.Value);

            [MethodImpl(Inline)]
            public static implicit operator HeapKey<GuidHeap>(GuidIndex src)
                => new HeapKey<GuidHeap>(src.Value);
        }
    }
}