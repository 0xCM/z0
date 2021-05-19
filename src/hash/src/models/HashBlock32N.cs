//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct HashBlock32<N>
        where N : unmanaged, ITypeNat
    {
        readonly Index<Hash32> Data;

        public uint SlotCount
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public Span<Hash32> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ReadOnlySpan<Hash32> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }
    }
}