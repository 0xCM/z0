//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

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
        public static implicit operator HeapKey(GuidIndex src)
            => new HeapKey(src.HeapKind, src.Value);

        [MethodImpl(Inline)]
        public static implicit operator HeapKey<GuidHeap>(GuidIndex src)
            => new HeapKey<GuidHeap>(src.Value);
    }
}