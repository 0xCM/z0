//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct HashBlock32
    {
        readonly Index<Hash32> Data;

        [MethodImpl(Inline)]
        internal HashBlock32(Index<Hash32> src)
        {
            Data = src;
        }

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

        public ref Hash32 this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }
    }
}