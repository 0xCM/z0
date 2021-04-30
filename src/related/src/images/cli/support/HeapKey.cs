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
        public readonly struct HeapKey : IHeapKey<HeapKey>
        {
            public HeapKind HeapKind {get;}

            public uint Value {get;}

            [MethodImpl(Inline)]
            public HeapKey(HeapKind heap, uint value)
            {
                HeapKind = heap;
                Value = value;
            }
        }
    }
}