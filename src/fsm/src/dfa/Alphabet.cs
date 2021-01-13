//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Alphabet<A> : IAlphabet<A>
        where A : unmanaged, ISymbol
    {
        readonly Index<A> Data;

        [MethodImpl(Inline)]
        public Alphabet(A[] src)
            => Data = src;

        public ref A this[ushort index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public A[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        public Span<A> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }


        [MethodImpl(Inline)]
        public static implicit operator Alphabet<A>(A[] src)
            => new Alphabet<A>(src);
    }
}