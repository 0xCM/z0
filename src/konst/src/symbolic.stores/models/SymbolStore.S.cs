//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines an <typeparamref name='S'/> symbol sequence
    /// </summary>
    public readonly struct SymbolStore<S>
        where S : unmanaged
    {
        readonly Index<Symbol<S>> Data;

        [MethodImpl(Inline)]
        public SymbolStore(Symbol<S>[] src)
            => Data = src;

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ref Symbol<S> this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref Symbol<S> this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        [MethodImpl(Inline)]
        public static implicit operator SymbolStore<S>(Symbol<S>[] src)
            => new SymbolStore<S>(src);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<S>(SymbolStore<S> src)
            => src.Data.View.Map(x => x.Value);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<Symbol<S>>(SymbolStore<S> src)
            => src.Data.View;
    }
}