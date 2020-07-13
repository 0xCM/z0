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
    using static ValueIndex;

    using static z;

    public readonly struct ValueIndex
    {
        [MethodImpl(Inline)]
        public static ValueIndex<T> create<T>(T[] data)
            where T : struct
                => new ValueIndex<T>(data);

        public static ValueIndex<T> create<T>(IEnumerable<T> data)
            where T : struct
                => new ValueIndex<T>(data.Array());
    }
    
    public readonly struct ValueIndex<T>
        where T : struct
    {
        public readonly T[] Data;

        [MethodImpl(Inline)]
        public static implicit operator ValueIndex<T>(T[] src)
            => new ValueIndex<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T[](ValueIndex<T> src)
            => src.Data;

        [MethodImpl(Inline)]   
        public static ValueIndex<T> operator + (ValueIndex<T> lhs, ValueIndex<T> rhs)
            => lhs.Concat(rhs);

        [MethodImpl(Inline)]
        public ValueIndex(T[] src)
            => Data = src;
        
        public ref T this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }
 
        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }
        
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data == null || Data.Length == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Length > 0;
        }

        [MethodImpl(Inline)]
        public ValueIndex<T> Replace(T[] data)
            => create(data);
        
        public ValueIndex<T> Reverse()
        {
            Array.Reverse(Data);
            return this;
        }

        public ValueIndex<T> Concat(ValueIndex<T> rhs)
            => create(concat(Data,rhs.Data));

        [MethodImpl(Inline)]
        public unsafe ValueIndex<S> Cast<S>()
            where S : struct
                => create(@as<T[],S[]>(edit(Data)));

        public ValueIndex<Y> Select<Y>(Func<T,Y> selector)
            where Y : struct       
             => create(from x in Data select selector(x));

        public ValueIndex<Z> SelectMany<Y,Z>(Func<T,ValueIndex<Y>> lift, Func<T,Y,Z> project)
            where Y : struct       
            where Z : struct       
                => create(from x in Data from y in lift(x).Data select project(x, y));

        public ValueIndex<Y> SelectMany<Y>(Func<T,ValueIndex<Y>> lift)
            where Y : struct 
                 => create(from x in Data from y in lift(x).Data select y);

        public ValueIndex<T> Where(Func<T,bool> predicate)
            => create(from x in Data where predicate(x) select x);


        [MethodImpl(Inline)]
        public bool Equals(ValueIndex<T> rhs)        
            => Data.Equals(rhs.Data);

        public static ValueIndex<T> Empty
            => create(sys.empty<T>());
    }
}