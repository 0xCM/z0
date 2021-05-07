//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct CliHeapKey : ICliHeapKey<CliHeapKey>
    {
        public CliHeapKind HeapKind {get;}

        public uint Value {get;}

        [MethodImpl(Inline)]
        public CliHeapKey(CliHeapKind heap, uint value)
        {
            HeapKind = heap;
            Value = value;
        }
    }
}