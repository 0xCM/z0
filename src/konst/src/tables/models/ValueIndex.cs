//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using api = Seq;

    public readonly struct ValueIndex<T> : IIndex<T>
        where T : struct
    {
        internal readonly T[] Data;

        [MethodImpl(Inline)]
        public ValueIndex(T[] src)
            => Data = insist(src);

        public T[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<T> Terms
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data?.Length ?? 0;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => api.empty(this);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => api.nonempty(this);
        }

        [MethodImpl(Inline)]
        public ref T Lookup(byte index)
            => ref Data[index];

        [MethodImpl(Inline)]
        public ref T Lookup(ushort index)
            => ref Data[index];

        [MethodImpl(Inline)]
        public ref T Lookup(uint index)
            => ref Data[index];

        [MethodImpl(Inline)]
        public ref T Lookup(ulong index)
            => ref Data[index];

        [MethodImpl(Inline)]
        public ref T Lookup(long index)
            => ref Data[index];

        public ref T this[byte index]
        {
            [MethodImpl(Inline)]
            get => ref Lookup(index);
        }

        public ref T this[ushort index]
        {
            [MethodImpl(Inline)]
            get => ref Lookup(index);
        }

        public ref T this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Lookup(index);
        }

        public ref T this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Lookup(index);
        }

        public ref T this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Lookup(index);
        }

        public ref T this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Lookup(index);
        }

        public T[] Content
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

        [MethodImpl(Inline)]
        public ValueIndex<T> Replace(T[] data)
            => api.values(data);

        [MethodImpl(Inline)]
        public ValueIndex<T> Reverse()
        {
            Array.Reverse(Data);
            return this;
        }

        [MethodImpl(Inline)]
        public bool Equals(ValueIndex<T> rhs)
            => Data.Equals(rhs.Data);

        [MethodImpl(Inline)]
        public ValueIndex<T> Concat(in ValueIndex<T> rhs)
            => api.values(concat(Data,rhs.Data));

        [MethodImpl(Inline)]
        public unsafe ValueIndex<S> Cast<S>()
            where S : struct
                => api.values(@as<T[],S[]>(edit(Data)));

        public ValueIndex<Y> Select<Y>(Func<T,Y> selector)
            where Y : struct
             => api.values(from x in Data select selector(x));

        public ValueIndex<Z> SelectMany<Y,Z>(Func<T,ValueIndex<Y>> lift, Func<T,Y,Z> project)
            where Y : struct
            where Z : struct
                => api.values(from x in Data from y in lift(x).Data select project(x, y));

        public ValueIndex<Y> SelectMany<Y>(Func<T,ValueIndex<Y>> lift)
            where Y : struct
                 => api.values(from x in Data from y in lift(x).Data select y);

        public ValueIndex<T> Where(Func<T,bool> predicate)
            => api.values(from x in Data where predicate(x) select x);

        [MethodImpl(Inline)]
        public static implicit operator ValueIndex<T>(T[] src)
            => new ValueIndex<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T[](ValueIndex<T> src)
            => src.Data;

        [MethodImpl(Inline)]
        public static ValueIndex<T> operator + (ValueIndex<T> lhs, ValueIndex<T> rhs)
            => lhs.Concat(rhs);

        public static ValueIndex<T> Empty
        {
            [MethodImpl(Inline)]
            get => default;
        }
    }
}