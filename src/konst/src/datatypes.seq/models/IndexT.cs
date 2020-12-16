//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static memory;

    using api = Seq;

    public readonly struct Index<T> : IIndex<T>
    {
        internal readonly T[] Data;

        [MethodImpl(Inline)]
        public Index(T[] content)
            => Data = content;

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

        public Deferred<T> Deferred
        {
            [MethodImpl(Inline)]
            get => api.defer(this);
        }

        public MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => z.address(Data);
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data == null || Data.Length == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsNonEmpty;
        }

        [MethodImpl(Inline)]
        public bit Search(Func<T,bool> predicate, out T found)
            => api.search(this, predicate, out found);

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

        public int Length
        {
            [MethodImpl(Inline)]
            get => (int)Data.Length;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Length;
        }

        public ref T First
        {
            [MethodImpl(Inline)]
            get => ref api.first(this);
        }

        public ref T Last
        {
            [MethodImpl(Inline)]
            get => ref api.last(this);
        }

        public Index<T> Reverse()
            => api.reverse(this);

        public Index<Y> Cast<Y>()
            => new Index<Y>(Storage.Select(x => z.cast<Y>(x)));

        public Index<Y> Select<Y>(Func<T,Y> selector)
             => api.map(this, selector);

        public Index<Z> SelectMany<Y,Z>(Func<T,Index<Y>> lift, Func<T,Y,Z> project)
             => api.map(this, lift, project);

        public Index<Y> SelectMany<Y>(Func<T,Index<Y>> lift)
             => api.map(this, lift);

        public Index<T> Where(Func<T,bool> predicate)
            => api.filter(this, predicate);

        [MethodImpl(Inline)]
        public static implicit operator Span<T>(Index<T> src)
            => src.Terms;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T>(Index<T> src)
            => src.View;

        [MethodImpl(Inline)]
        public static implicit operator Index<T>(T[] src)
            => new Index<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T[](Index<T> src)
            => src.Data;

        public static Index<T> Empty
        {
           [MethodImpl(Inline)]
           get => api.EmptyIndex<T>();
        }
    }
}