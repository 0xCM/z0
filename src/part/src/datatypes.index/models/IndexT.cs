//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public readonly struct Index<T> : IIndex<T>
    {
        readonly T[] Data;

        [MethodImpl(Inline)]
        public Index(T[] content)
            => Data = content;
        public int Length
        {
            [MethodImpl(Inline)]
            get => Data?.Length ?? 0;
        }

        public Span<T> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ReadOnlySpan<T> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<T> Terms
        {
            [MethodImpl(Inline)]
            get => Data;
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

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsNonEmpty;
        }

        public ref T this[long i]
        {
            [MethodImpl(Inline)]
            get => ref seek(Data,i);
        }

        public ref T this[ulong i]
        {
            [MethodImpl(Inline)]
            get => ref seek(Data,i);
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

        public ref T First
        {
            [MethodImpl(Inline)]
            get => ref Index.first(Data);
        }

        public ref T Last
        {
            [MethodImpl(Inline)]
            get => ref Index.last(Data);
        }

        public string Format()
            => Index.delimit(Data).Format();

        public override string ToString()
            => Format();

        public Index<T> Reverse()
            => Index.reverse(Data);

        [MethodImpl(Inline)]
        public bit Search(Func<T,bool> predicate, out T found)
            => Index.search(this, predicate, out found);

        public Index<Y> Cast<Y>()
            => new Index<Y>(Data.Select(x => cast<Y>(x)));

        public Index<Y> Select<Y>(Func<T,Y> selector)
             => Index.map(Data, selector);

        public Index<Z> SelectMany<Y,Z>(Func<T,Index<Y>> lift, Func<T,Y,Z> project)
             => Index.map(Data, lift, project);

        public Index<Y> SelectMany<Y>(Func<T,Index<Y>> lift)
             => Index.map(Data, lift);

        public Index<T> Where(Func<T,bool> predicate)
            => Index.filter(Data, predicate);

        [MethodImpl(Inline)]
        public static implicit operator Span<T>(Index<T> src)
            => src.Storage;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T>(Index<T> src)
            => src.Storage;

        [MethodImpl(Inline)]
        public static implicit operator Index<T>(T[] src)
            => new Index<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T[](Index<T> src)
            => src.Storage;

        public static Index<T> Empty
        {
           [MethodImpl(Inline)]
           get => new Index<T>(sys.empty<T>());
        }
    }
}