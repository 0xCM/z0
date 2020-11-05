//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using api = Seq;

    public readonly struct IndexedSeq<I,T> : IIndex<IndexedSeq<I,T>,I,T>
        where I : unmanaged
    {
        readonly T[] Data;

        [MethodImpl(Inline)]
        public IndexedSeq(T[] src)
            => Data = src;

        public Span<T> Terms
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ReadOnlySpan<T> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public T[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ref T this[I index]
        {
            [MethodImpl(Inline)]
            get => ref seek(Terms, @as<I,uint>(index));
        }

        uint Length
        {
            [MethodImpl(Inline)]
            get => (uint)(Data?.Length ?? 0);
        }

        public I Count
        {
            [MethodImpl(Inline)]
            get => @as<uint,I>(Length);
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Length == 0;
        }

        int IMeasured.Length
            => (int)Length;

        ref T IIndex<T>.this[int index]
            => ref Data[index];

        [MethodImpl(Inline)]
        public bool Equals(IndexedSeq<I,T> rhs)
            => Data?.Equals(rhs.Data) ?? false;

        [MethodImpl(Inline)]
        public IndexedSeq<I,T> WithContent(IEnumerable<T> content)
            => api.indexed<I,T>(content);

        [MethodImpl(Inline)]
        public IndexedSeq<I,T> Concat(IndexedSeq<I,T> rhs)
            => api.concat(this, rhs);

        /// <summary>
        /// Creates an indexed sequence from a parameter array
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UInt8k)]
        private static IndexedSeq<I,X> view<X>(IEnumerable<X> src)
            => new IndexedSeq<I,X>(src.Array());

        public IndexedSeq<I,Y> Select<Y>(Func<T,Y> selector)
             => Data.Select(selector);

        public IndexedSeq<I,Z> SelectMany<Y,Z>(Func<T,IndexedSeq<I,Y>> lift, Func<T,Y,Z> project)
            => view(from x in Data from y in lift(x).Data select project(x, y));

        public IndexedSeq<I,Y> SelectMany<Y>(Func<T,IndexedSeq<I,Y>> lift)
            => view(from x in Data from y in lift(x).Data select y);

        public IndexedSeq<I,T> Where(Func<T,bool> predicate)
            => view(from x in Data where predicate(x) select x);

        [MethodImpl(Inline)]
        public static implicit operator IndexedSeq<I,T>(T[] src)
            => new IndexedSeq<I,T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T[](IndexedSeq<I,T> src)
            => src.Data;
    }
}