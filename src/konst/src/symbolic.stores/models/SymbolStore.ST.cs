//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct SymbolStore<S,T>
        where S : unmanaged
        where T : unmanaged
    {
        readonly Index<Symbol<S,T>> Data;

        [MethodImpl(Inline)]
        public SymbolStore(Symbol<S,T>[] src)
            => Data = src;

        public ReadOnlySpan<Symbol<S,T>> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<Symbol<S,T>> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ref readonly Symbol<S,T> this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref readonly Symbol<S,T> this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        [MethodImpl(Inline)]
        public static implicit operator SymbolStore<S>(SymbolStore<S,T> src)
            => new SymbolStore<S>(src.Data.Map(x => x.Simplified));

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<S>(SymbolStore<S,T> src)
            => src.Data.View.Map(x => x.Value);

        [MethodImpl(Inline)]
        public static implicit operator SymbolStore<S,T>(Symbol<S,T>[] src)
            => new SymbolStore<S,T>(src);
    }
}