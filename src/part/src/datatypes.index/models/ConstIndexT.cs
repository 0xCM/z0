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

    public readonly struct ConstIndex<T> : IConstIndex<T>
    {
        readonly T[] Data;

        [MethodImpl(Inline)]
        public ConstIndex(T[] content)
            => Data = content;

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data?.Length ?? 0;
        }

        public ReadOnlySpan<T> View
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

        public ref readonly T this[long i]
        {
            [MethodImpl(Inline)]
            get => ref seek(Data,i);
        }

        public ref readonly T this[ulong i]
        {
            [MethodImpl(Inline)]
            get => ref seek(Data,i);
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Length;
        }

        public ref readonly T First
        {
            [MethodImpl(Inline)]
            get => ref Index.first(Data);
        }

        public ref readonly T Last
        {
            [MethodImpl(Inline)]
            get => ref Index.last(Data);
        }

        [MethodImpl(Inline)]
        public Index<T> Thaw()
            => Data;
        public string Format()
            => Index.delimit(Data).Format();

        public override string ToString()
            => Format();

        public Index<T> Reverse()
            => Index.reverse(Data);

        public bit Search(Func<T,bool> predicate, out T found)
            => Index.search(Data, predicate, out found);

        public ConstIndex<Y> Cast<Y>()
            => Data.Select(x => cast<Y>(x));

        public ConstIndex<Y> Select<Y>(Func<T,Y> selector)
             => Index.map(Data, selector);

        public ConstIndex<Z> SelectMany<Y,Z>(Func<T,Index<Y>> lift, Func<T,Y,Z> project)
             => Index.map(Data, lift, project);

        public ConstIndex<Y> SelectMany<Y>(Func<T,Index<Y>> lift)
             => Index.map(Data, lift);

        public ConstIndex<T> Where(Func<T,bool> predicate)
            => Index.filter(Data, predicate);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T>(ConstIndex<T> src)
            => src.View;

        [MethodImpl(Inline)]
        public static implicit operator ConstIndex<T>(T[] src)
            => new ConstIndex<T>(src);

        public static ConstIndex<T> Empty
        {
           [MethodImpl(Inline)]
           get => new ConstIndex<T>(sys.empty<T>());
        }
    }
}