//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    using static Konst;
    using static z;

    public interface IAlphabet<A> : IIndex<ushort,A>
        where A : unmanaged, ISymbol
    {

    }

    public readonly struct Alphabet<A> : IAlphabet<A>
        where A : unmanaged, ISymbol
    {
        readonly Indexed<A> Data;

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

        public Span<A> Terms
        {
            [MethodImpl(Inline)]
            get => Data.Terms;
        }

        [MethodImpl(Inline)]
        public static implicit operator Alphabet<A>(A[] src)
            => new Alphabet<A>(src);
    }
}