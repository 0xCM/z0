//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public readonly struct Symbols<K>
        where K : unmanaged
    {
        readonly Index<Sym<K>> Data;

        [MethodImpl(Inline)]
        public Symbols(Index<Sym<K>> src)
        {
            Data = src;
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
    }
}