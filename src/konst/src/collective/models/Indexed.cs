//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static z;

    using api = Seq;

    public readonly struct Indexed<T> : IIndex<T>
    {
        internal readonly T[] Data;

        public ReadOnlySpan<T> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<T> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
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
        public Indexed(T[] content)
            => Data = content;

        public ref T this[int i]
        {
            [MethodImpl(Inline)]
            get => ref Data[i];
        }

        public ref T this[uint i]
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

        public Indexed<T> Reverse()
        {
            Array.Reverse(Data);
            return this;
        }

        public Indexed<Y> Select<Y>(Func<T,Y> selector)
             => api.map(this, selector);

        public Indexed<Z> SelectMany<Y,Z>(Func<T,Indexed<Y>> lift, Func<T,Y,Z> project)
             => api.map(this, lift, project);

        public Indexed<Y> SelectMany<Y>(Func<T,Indexed<Y>> lift)
             => api.map(this, lift);

        public Indexed<T> Where(Func<T,bool> predicate)
            => api.filter(this, predicate);

        public static Indexed<T> Empty
        {
           [MethodImpl(Inline)]
           get => api.EmptyIndex<T>();
        }

        [MethodImpl(Inline)]
        public static implicit operator Span<T>(Indexed<T> src)
            => src.Edit;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T>(Indexed<T> src)
            => src.View;

        [MethodImpl(Inline)]
        public static implicit operator Indexed<T>(T[] src)
            => new Indexed<T>(src);

       [MethodImpl(Inline)]
        public static implicit operator T[](Indexed<T> src)
            => src.Data;
    }
}