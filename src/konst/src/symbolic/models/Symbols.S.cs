//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines an <typeparamref name='S'/> symbol sequence
    /// </summary>
    public readonly struct Symbols<S>
        where S : unmanaged
    {
        readonly TableSpan<Symbol<S>> Data;

        [MethodImpl(Inline)]
        public static implicit operator Symbols<S>(Symbol<S>[] src)
            => new Symbols<S>(src);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<S>(Symbols<S> src)
            => src.Data.View.Map(x => x.Value);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<Symbol<S>>(Symbols<S> src)
            => src.Data.View;

        [MethodImpl(Inline)]
        public Symbols(Symbol<S>[] src)
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
    }
}