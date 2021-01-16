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

    using static Part;
    using static memory;

    public readonly struct IndexedView<T> : IConstIndex<T>
    {
        readonly Index<T> Data;

        [MethodImpl(Inline)]
        public IndexedView(T[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public IndexedView(Index<T> src)
            => Data = src;

        public T[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ReadOnlySpan<T> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ref readonly T this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Length == 0;
        }

        [MethodImpl(Inline)]
        public bool Equals(IndexedView<T> rhs)
            => Data.Equals(rhs.Data);

        public string Format()
            => Index.delimit(Data).Format();

        public override string ToString()
            => Format();

        /// <summary>
        /// Creates an indexed sequence from a parameter array
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UInt8k)]
        static IndexedView<X> view<X>(IEnumerable<X> src)
            => new IndexedView<X>(src.Array());

        public IndexedView<Y> Select<Y>(Func<T,Y> selector)
             => Data.Select(selector);

        public IndexedView<Z> SelectMany<Y,Z>(Func<T,IndexedView<Y>> lift, Func<T,Y,Z> project)
            => view(from x in Data from y in lift(x).Data select project(x, y));

        public IndexedView<Y> SelectMany<Y>(Func<T,IndexedView<Y>> lift)
            => view(from x in Data from y in lift(x).Data select y);

        public IndexedView<T> Where(Func<T,bool> predicate)
            => view(from x in Data where predicate(x) select x);

        [MethodImpl(Inline)]
        public static implicit operator IndexedView<T>(T[] src)
            => new IndexedView<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator IndexedView<T>(Index<T> src)
            => new IndexedView<T>(src.Storage);

        [MethodImpl(Inline)]
        public static implicit operator T[](IndexedView<T> src)
            => src.Data;
    }
}