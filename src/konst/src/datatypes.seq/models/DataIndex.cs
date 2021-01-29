//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    using api = Seq;

    public readonly struct DataIndex<T> : IIndex<T>
        where T : struct
    {
        internal readonly T[] Data;

        [MethodImpl(Inline)]
        public DataIndex(T[] src)
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
            get => Length == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Length != 0;
        }

        [MethodImpl(Inline)]
        public ref T Lookup(byte index)
            => ref seek(Data,index);

        [MethodImpl(Inline)]
        public ref T Lookup(ushort index)
            => ref seek(Data,index);

        [MethodImpl(Inline)]
        public ref T Lookup(uint index)
            => ref Data[index];

        [MethodImpl(Inline)]
        public ref T Lookup(ulong index)
            => ref seek(Data,index);

        [MethodImpl(Inline)]
        public ref T Lookup(long index)
            => ref seek(Data,index);

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

        public ref T First
        {
            [MethodImpl(Inline)]
            get => ref first(Data);
        }

        public ref T Last
        {
            [MethodImpl(Inline)]
            get => ref seek(Data,Length - 1);
        }

        [MethodImpl(Inline)]
        public DataIndex<T> Replace(T[] data)
            => api.values(data);

        [MethodImpl(Inline)]
        public DataIndex<T> Reverse()
        {
            Array.Reverse(Data);
            return this;
        }

        [MethodImpl(Inline)]
        public bool Equals(DataIndex<T> rhs)
            => Data.Equals(rhs.Data);

        [MethodImpl(Inline)]
        public DataIndex<T> Concat(in DataIndex<T> rhs)
            => api.values(Arrays.concat(Data, rhs.Data));

        [MethodImpl(Inline)]
        public unsafe DataIndex<S> Cast<S>()
            where S : struct
                => api.values(@as<T[],S[]>(edit(Data)));

        public DataIndex<Y> Select<Y>(Func<T,Y> selector)
            where Y : struct
             => api.values(from x in Data select selector(x));

        public DataIndex<Z> SelectMany<Y,Z>(Func<T,DataIndex<Y>> lift, Func<T,Y,Z> project)
            where Y : struct
            where Z : struct
                => api.values(from x in Data from y in lift(x).Data select project(x, y));

        public DataIndex<Y> SelectMany<Y>(Func<T,DataIndex<Y>> lift)
            where Y : struct
                 => api.values(from x in Data from y in lift(x).Data select y);

        public DataIndex<T> Where(Func<T,bool> predicate)
            => api.values(from x in Data where predicate(x) select x);

        [MethodImpl(Inline)]
        public static implicit operator DataIndex<T>(T[] src)
            => new DataIndex<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T[](DataIndex<T> src)
            => src.Data;

        [MethodImpl(Inline)]
        public static DataIndex<T> operator + (DataIndex<T> lhs, DataIndex<T> rhs)
            => lhs.Concat(rhs);

        public static DataIndex<T> Empty
        {
            [MethodImpl(Inline)]
            get => default;
        }
    }
}