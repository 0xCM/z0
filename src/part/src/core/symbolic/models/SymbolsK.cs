//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct Symbols<K>
        where K : unmanaged
    {
        readonly Index<Sym<K>> Data;

        readonly Index<K> _Kinds;

        [MethodImpl(Inline)]
        Symbols(Index<Sym<K>> src)
        {
            Data = src;
            _Kinds = src.Select(x => x.Kind);
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

        public bool Match(SymExpr src, out Sym<K> dst)
        {
            var count = Count;
            var view = View;
            for(var i=0; i<count; i++)
            {
                ref readonly var sym = ref skip(view,i);
                if(sym.Expr.Equals(src))
                {
                    dst = sym;
                    return true;
                }
            }
            dst = Sym<K>.Empty;
            return false;
        }

        public bool MatchKind(SymExpr src, out K dst)
        {
            if(Match(src, out var matched))
            {
                dst = matched.Kind;
                return true;
            }
            else
            {
                dst = default;
                return false;
            }
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
        public static implicit operator Symbols<K>(Sym<K>[] src)
            => new Symbols<K>(src);

        [MethodImpl(Inline)]
        public static implicit operator Sym<K>[](Symbols<K> src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator Index<K,Sym<K>>(Symbols<K> src)
            => new Index<K, Sym<K>>(src.Data);
    }
}