//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct StringIndex : IHeapKey<StringIndex>
    {
        public HeapKind HeapKind => HeapKind.String;

        public uint Value {get;}

        [MethodImpl(Inline)]
        public StringIndex(uint value)
        {
            Value = value;
        }

        [MethodImpl(Inline)]
        public static implicit operator HeapKey(StringIndex src)
            => new HeapKey(src.HeapKind, src.Value);

        [MethodImpl(Inline)]
        public static implicit operator HeapKey<StringHeap>(StringIndex src)
            => new HeapKey<StringHeap>(src.Value);
    }
}