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
        public readonly struct HeapKey<K> : IHeapKey<HeapKey<K>>
            where K : struct, IHeap
        {
            public uint Value {get;}

            [MethodImpl(Inline)]
            public HeapKey(uint value)
                => Value = value;

            public HeapKind HeapKind
            {
                [MethodImpl(Inline)]
                get => default(K).Kind;
            }

            [MethodImpl(Inline)]
            public static implicit operator HeapKey(HeapKey<K> src)
                => new HeapKey(src.HeapKind, src.Value);
        }
    }
}