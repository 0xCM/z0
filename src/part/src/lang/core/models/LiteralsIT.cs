//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Literals<I,T> : IIndex<Literal<I,T>>
        where I : IComparable<I>
    {
        readonly Index<Literal<I,T>> Data;

        [MethodImpl(Inline)]
        public Literals(Literal<I,T>[] src)
            => Data = src;

        public ReadOnlySpan<Literal<I,T>> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<Literal<I,T>> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ref Literal<I,T> First
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public Literal<I,T>[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }


        [MethodImpl(Inline)]
        public Literals<I,T> Refresh(Literal<I,T>[] src)
            => src;

        [MethodImpl(Inline)]
        public static implicit operator Literals<I,T>(Literal<I,T>[] src)
            => new Literals<I,T>(src);
    }
}