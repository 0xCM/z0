//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;
    using static core;

    using api = Symbols;

    public class Symbols<K> : ISymIndex<K>
        where K : unmanaged
    {
        readonly Index<Sym<K>> Data;

        readonly Index<K> _Kinds;

        readonly Dictionary<string,Sym<K>> _SymbolMap;

        readonly SymIndex _Untyped;

        Symbols()
        {

        }

        [MethodImpl(Inline)]
        internal Symbols(Index<Sym<K>> src, Dictionary<string,Sym<K>> lookup)
        {
            Data = src;
            _Kinds = src.Select(x => x.Kind);
            _SymbolMap = lookup;
            _Untyped = CreateUntyped();
        }

        public ref readonly Sym<K> this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref readonly Sym<K> this[K index]
        {
            [MethodImpl(Inline)]
            get => ref Data[bw16(index)];
        }

        public bool Lookup(SymExpr src, out Sym<K> dst)
            => _SymbolMap.TryGetValue(src.Text, out dst);

        /// <summary>
        /// Presents an untyped view of the source data
        /// </summary>
        [MethodImpl(Inline)]
        public SymIndex Untyped()
            => _Untyped;

        SymIndex CreateUntyped()
        {
            var symbols = Data.Select(x => api.untyped(x));
            var map = _SymbolMap.Map(x => (x.Key, api.untyped(x.Value))).ToDictionary();
            return new SymIndex(symbols,map);
        }

        public ReadOnlySpan<K> Kinds
        {
            [MethodImpl(Inline)]
            get => _Kinds;
        }

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

        public ref Sym<K> First
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }

        public ReadOnlySpan<Sym<K>> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        [MethodImpl(Inline)]
        public static implicit operator Sym<K>[](Symbols<K> src)
            => src.Data;
    }
}