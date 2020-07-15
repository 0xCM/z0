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
    
    public readonly struct ValueIndex<T> : IIndexedSeq<ValueIndex<T>,T>
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
        {
            Data = insist(src);
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }
        
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Empty(this);
        }
        
        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => NonEmpty(this);
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
            => Indexed.values(data);
        
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
            => Indexed.values(concat(Data,rhs.Data));

        [MethodImpl(Inline)]
        public unsafe ValueIndex<S> Cast<S>()
            where S : struct
                => Indexed.values(@as<T[],S[]>(edit(Data)));

        public ValueIndex<Y> Select<Y>(Func<T,Y> selector)
            where Y : struct       
             => Indexed.values(from x in Data select selector(x));

        public ValueIndex<Z> SelectMany<Y,Z>(Func<T,ValueIndex<Y>> lift, Func<T,Y,Z> project)
            where Y : struct       
            where Z : struct       
                => Indexed.values(from x in Data from y in lift(x).Data select project(x, y));

        public ValueIndex<Y> SelectMany<Y>(Func<T,ValueIndex<Y>> lift)
            where Y : struct 
                 => Indexed.values(from x in Data from y in lift(x).Data select y);

        public ValueIndex<T> Where(Func<T,bool> predicate)
            => Indexed.values(from x in Data where predicate(x) select x);

        public static ValueIndex<T> Empty
        {
            [MethodImpl(Inline)]
            get => default;
        }
    }
}