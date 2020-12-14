//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using api = Seq;

    public readonly struct Index<T> : IIndex<T>
    {
        internal readonly T[] Data;

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

        public Span<T> Edit
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
            get => new Deferred<T>(Storage);
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

        [MethodImpl(Inline)]
        public Index(T[] content)
            => Data = content;

        public ref T this[long i]
        {
            [MethodImpl(Inline)]
            get => ref Data[i];
        }

        public ref T this[ulong i]
        {
            [MethodImpl(Inline)]
            get => ref Data[i];
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
            => ref this[0];

        public ref T Last
             => ref this[Length - 1];

        public Index<T> Reverse()
        {
            Array.Reverse(Data);
            return this;
        }

        public Index<Y> Cast<Y>()
            => new Index<Y>(Storage.Select(x => cast<Y>(x)));

        public Index<Y> Select<Y>(Func<T,Y> selector)
             => api.map(this, selector);

        public Index<Z> SelectMany<Y,Z>(Func<T,Index<Y>> lift, Func<T,Y,Z> project)
             => api.map(this, lift, project);

        public Index<Y> SelectMany<Y>(Func<T,Index<Y>> lift)
             => api.map(this, lift);

        public Index<T> Where(Func<T,bool> predicate)
            => api.filter(this, predicate);

        public static Index<T> Empty
        {
           [MethodImpl(Inline)]
           get => api.EmptyIndex<T>();
        }

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
    }
}