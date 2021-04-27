//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

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