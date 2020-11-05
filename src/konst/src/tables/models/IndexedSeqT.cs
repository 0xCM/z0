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

    /// <summary>
    /// Reifies a canonical indexed sequence container
    /// </summary>
    public readonly struct IndexedSeq<T> : IIndex<T>
    {
        readonly T[] Data;

        [MethodImpl(Inline)]
        public IndexedSeq(T[] src)
            => Data = insist(src);

        [MethodImpl(Inline)]
        public IndexedSeq(T[] src, bool @internal)
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

        public ref T Head
        {
            [MethodImpl(Inline)]
            get => ref Data[0];
        }

        public ref T Tail
        {
            [MethodImpl(Inline)]
            get => ref Data[Length - 1];
        }

        public int Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public IndexedSeq<T> Reverse()
        {
            Array.Reverse(Data);
            return this;
        }

        public bool IsEmpty
        {
             [MethodImpl(Inline)]
             get => Data.Length == 1 && object.Equals(default, Head);
        }

        public bool IsNonEmpty
        {
             [MethodImpl(Inline)]
             get => !IsEmpty;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        [MethodImpl(Inline)]
        uint IFinite.Count()
            => (uint)Data.Length;

        public ref T this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        [MethodImpl(Inline)]
        public ref T Lookup(int index)
            => ref this[index];

        [MethodImpl(Inline)]
        public IndexedSeq<T> WithContent(IEnumerable<T> content)
            => api.indexed(content);

        [MethodImpl(Inline)]
        public bool Equals(IndexedSeq<T> rhs)
            => Data.Equals(rhs.Data);

        [MethodImpl(Inline)]
        public IndexedSeq<T> Concat(IndexedSeq<T> rhs)
            => api.concat(this, rhs);

        public IndexedSeq<Y> Select<Y>(Func<T,Y> selector)
             => api.indexed(from x in Data select selector(x));

        public IndexedSeq<Z> SelectMany<Y,Z>(Func<T,IndexedSeq<Y>> lift, Func<T,Y,Z> project)
            => api.indexed(from x in Data
                          from y in lift(x).Data
                          select project(x, y));

        public IndexedSeq<Y> SelectMany<Y>(Func<T,IndexedSeq<Y>> lift)
            => api.indexed(from x in Data
                          from y in lift(x).Data
                          select y);

        public IndexedSeq<T> Where(Func<T,bool> predicate)
            => api.indexed(from x in Data where predicate(x) select x);

        /// <summary>
        /// Implicitly constructs a sequence from an array
        /// </summary>
        /// <param name="src">The source array</param>
        [MethodImpl(Inline)]
        public static implicit operator IndexedSeq<T>(T[] src)
            => api.indexed(src);
    }

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