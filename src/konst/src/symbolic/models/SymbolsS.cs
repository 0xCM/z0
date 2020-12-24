//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Symbols<S> : IIndex<S>, ITextual
        where S : unmanaged, ISymbol
    {
        readonly Index<S> Data;

        public Symbols(S[] src)
            => Data = src;

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

        [MethodImpl(Inline)]
        public static implicit operator Symbols<S>(S[] src)
            => new Symbols<S>(src);
    }
}