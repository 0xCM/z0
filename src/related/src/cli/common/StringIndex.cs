//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Images
    {
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
        }
    }
}