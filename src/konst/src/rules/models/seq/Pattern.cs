//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    readonly partial struct Rules
    {
        partial struct Sequence
        {

            public readonly struct Pattern<T> : IIndex<T>
            {
                readonly Index<T> Terms;

                [MethodImpl(Inline)]
                public Pattern(T[] terms)
                    => Terms = terms;

                public ReadOnlySpan<T> View
                {
                    [MethodImpl(Inline)]
                    get => Terms.View;
                }

                public Span<T> Edit
                {
                    [MethodImpl(Inline)]
                    get => Terms.Edit;
                }

                public T[] Storage
                {
                    [MethodImpl(Inline)]
                    get => Terms.Storage;
                }

            }

            public readonly struct Pattern<I,T> : IIndex<I,T>
                where I : unmanaged
            {
                readonly Index<T> Terms;

                [MethodImpl(Inline)]
                public Pattern(T[] terms)
                    => Terms = terms;

                public ref T this[I index]
                {
                    get => ref Terms[0];
                }

                public ReadOnlySpan<T> View
                {
                    [MethodImpl(Inline)]
                    get => Terms.View;
                }

                public Span<T> Edit
                {
                    [MethodImpl(Inline)]
                    get => Terms.Edit;
                }

                public T[] Storage
                {
                    [MethodImpl(Inline)]
                    get => Terms.Storage;
                }

            }

        }
    }
}