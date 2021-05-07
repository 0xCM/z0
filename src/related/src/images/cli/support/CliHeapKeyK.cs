//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct CliHeapKey<K> : ICliHeapKey<CliHeapKey<K>>
        where K : struct, ICliHeap
    {
        public uint Value {get;}

        [MethodImpl(Inline)]
        public CliHeapKey(uint value)
            => Value = value;

        public CliHeapKind HeapKind
        {
            [MethodImpl(Inline)]
            get => default(K).Kind;
        }

        [MethodImpl(Inline)]
        public static implicit operator CliHeapKey(CliHeapKey<K> src)
            => new CliHeapKey(src.HeapKind, src.Value);
    }
}