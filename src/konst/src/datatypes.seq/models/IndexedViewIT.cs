//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    public readonly struct IndexedView<I,T> : IIndexedView<IndexedView<I,T>,I,T>
        where I : unmanaged
    {
        readonly T[] Data;

        [MethodImpl(Inline)]
        public IndexedView(T[] src)
            => Data = src;

        public ReadOnlySpan<T> Terms
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ref readonly T this[I index]
        {
            [MethodImpl(Inline)]
            get => ref skip(Terms, @as<I,uint>(index));
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

        public T[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Length == 0;
        }

        [MethodImpl(Inline)]
        public bool Equals(IndexedView<I,T> rhs)
            => Data?.Equals(rhs.Data) ?? false;
        public string Format()
            => Seq.delimit(Storage).Format();

        /// <summary>
        /// Creates an indexed sequence from a parameter array
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UInt8k)]
        static IndexedView<I,X> view<X>(IEnumerable<X> src)
            => new IndexedView<I,X>(src.Array());

        public IndexedView<I,Y> Select<Y>(Func<T,Y> selector)
             => Data.Select(selector);

        public IndexedView<I,Z> SelectMany<Y,Z>(Func<T,IndexedView<I,Y>> lift, Func<T,Y,Z> project)
            => view(from x in Data from y in lift(x).Data select project(x, y));

        public IndexedView<I,Y> SelectMany<Y>(Func<T,IndexedView<I,Y>> lift)
            => view(from x in Data from y in lift(x).Data select y);

        public IndexedView<I,T> Where(Func<T,bool> predicate)
            => view(from x in Data where predicate(x) select x);

        [MethodImpl(Inline)]
        public static implicit operator IndexedView<I,T>(T[] src)
            => new IndexedView<I,T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T[](IndexedView<I,T> src)
            => src.Data;
    }
}