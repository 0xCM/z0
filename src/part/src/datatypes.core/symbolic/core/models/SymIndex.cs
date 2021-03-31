//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = Symbols;

    public readonly struct Symbols<K> : IIndex<Sym<K>>
        where K : unmanaged
    {
        readonly Index<Sym<K>> Data;

        [MethodImpl(Inline)]
        public Symbols(Sym<K>[] src)
            => Data = src;

        public bool Contains(SymExpr src)
            => api.contains(this, src);

        public bool Match(SymExpr src, out Sym<K> dst)
            => api.match(this, src, out dst);

        public Sym<K>[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ref readonly Sym<K> this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ReadOnlySpan<Sym<K>> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        [MethodImpl(Inline)]
        public static implicit operator Symbols<K>(Sym<K>[] src)
            => new Symbols<K>(src);

        [MethodImpl(Inline)]
        public static implicit operator Sym<K>[](Symbols<K> src)
            => src.Storage;
    }
}