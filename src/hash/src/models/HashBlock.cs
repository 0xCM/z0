//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct HashBlock<T>
        where T : unmanaged, IHashCode<T,T>
    {
        readonly Index<Hash<T>> Data;

        public ref Hash<T> this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public uint SlotCount
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public Span<Hash<T>> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ReadOnlySpan<Hash<T>> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

    }

    public readonly struct HashBlock<N,T>
        where N : unmanaged, ITypeNat
        where T : unmanaged, IHashCode<T,T>
    {
        readonly Index<Hash<T>> Data;

        public ref Hash<T> this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public uint SlotCount
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public Span<Hash<T>> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ReadOnlySpan<Hash<T>> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }
    }
}