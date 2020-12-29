//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Literals<C,T> : IIndex<Literal<C,T>>
    {
        readonly TableSpan<Literal<C,T>> Data;

        [MethodImpl(Inline)]
        public Literals(Literal<C,T>[] src)
            => Data = src;

        public ReadOnlySpan<Literal<C,T>> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<Literal<C,T>> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ref Literal<C,T> First
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public Literal<C,T>[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }


        [MethodImpl(Inline)]
        public Literals<C,T> Refresh(Literal<C,T>[] src)
            => src;

        [MethodImpl(Inline)]
        public static implicit operator Literals<C,T>(Literal<C,T>[] src)
            => new Literals<C,T>(src);
    }
}