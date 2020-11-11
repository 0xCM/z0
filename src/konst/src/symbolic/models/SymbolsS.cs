//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Symbols<S> : ITextual
        where S : unmanaged, ISymbol
    {
        readonly TableSpan<S> Data;

        public Symbols(S[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator Symbols<S>(S[] src)
            => new Symbols<S>(src);

        public S[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        public Count Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan<char> Render()
            => Symbolic.render<S>(Data.Storage);

        public string Format()
            => z.format(Render());
    }
}