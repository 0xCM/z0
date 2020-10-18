//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct SymbolStore<S,T,N>
        where S : unmanaged
        where T : unmanaged
        where N : unmanaged, ITypeNat
    {
        readonly TableSpan<Symbol<S,T,N>> Data;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<S>(SymbolStore<S,T,N> src)
            => src.Data.View.Map(x => x.Value);

        [MethodImpl(Inline)]
        public static implicit operator SymbolStore<S>(SymbolStore<S,T,N> src)
            => new SymbolStore<S>(src.Data.Map(x => x.Simplified));

        [MethodImpl(Inline)]
        public static implicit operator SymbolStore<S,T,N>(Symbol<S,T,N>[] src)
            => new SymbolStore<S,T,N>(src);

        [MethodImpl(Inline)]
        public SymbolStore(Symbol<S,T,N>[] src)
            => Data = src;

        public ref Symbol<S,T,N> this[ulong index]
        {
             [MethodImpl(Inline)]
             get => ref Data[index];
        }

        public ref Symbol<S,T,N> this[long index]
        {
             [MethodImpl(Inline)]
             get => ref Data[index];
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }
    }
}