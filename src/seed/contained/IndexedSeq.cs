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

    public class IndexedSeq
    {
        [MethodImpl(Inline)]
        public static IndexedSeq<T> create<T>(params T[] src)    
            => new IndexedSeq<T>(src);
    }

    /// <summary>
    /// Reifies a canonical indexed sequence container
    /// </summary>
    public readonly struct IndexedSeq<T> : IIndexedSeq<IndexedSeq<T>,T>
    {        
        readonly T[] Data;

        /// <summary>
        /// Implicitly constructs a sequence from an array
        /// </summary>
        /// <param name="src">The source array</param>
        [MethodImpl(Inline)]
        public static implicit operator IndexedSeq<T>(T[] src)
            => new IndexedSeq<T>(src);

        [MethodImpl(Inline)]
        public IndexedSeq(params T[] src)
        {
            Data = Conform(src);
        }

        [MethodImpl(Inline)]
        public IndexedSeq(IEnumerable<T> src)
        {
            Data = Conform(src?.ToArray());
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

        public int Count 
        { 
            [MethodImpl(Inline)] 
            get => Data.Length; 
        }

        public IndexedSeq<T> Reverse()
        {
            Array.Reverse(Data);
            return this;
        }
        
        public bool IsEmpty 
        {
             [MethodImpl(Inline)] 
             get => Data.Length == 1 && object.Equals(default, Head); 
        }

        public bool IsNonEmpty 
        {
             [MethodImpl(Inline)] 
             get => !IsEmpty; 
        }

        public int Length 
        { 
            [MethodImpl(Inline)] 
            get => Data.Length;
        }

        [MethodImpl(Inline)]
        int IFinite.Count() 
            => Count;

        public ref T this[int index] 
        { 
            [MethodImpl(Inline)] 
            get => ref Data[index]; 
        }

        [MethodImpl(Inline)]
        public ref T Lookup(int index) 
            => ref this[index];

        [MethodImpl(Inline)]
        public IndexedSeq<T> WithContent(IEnumerable<T> content)
            => new IndexedSeq<T>(content);

        IEnumerable<T> IContented<IEnumerable<T>>.Content 
            => Data;

        [MethodImpl(Inline)]
        public bool Equals(IndexedSeq<T> rhs)
            => Data.Equals(rhs.Data);

        [MethodImpl(Inline)]
        public IndexedSeq<T> Concat(IndexedSeq<T> rhs)
            => new IndexedSeq<T>(Data.Concat(rhs.Data));

        public IndexedSeq<Y> Select<Y>(Func<T,Y> selector)       
             => Seq.indexed(from x in Data select selector(x));

        public IndexedSeq<Z> SelectMany<Y,Z>(Func<T,IndexedSeq<Y>> lift, Func<T,Y,Z> project)
            => Seq.indexed(from x in Data
                          from y in lift(x).Data
                          select project(x, y));

        public IndexedSeq<Y> SelectMany<Y>(Func<T,IndexedSeq<Y>> lift)
            => Seq.indexed(from x in Data
                          from y in lift(x).Data
                          select y);

        public IndexedSeq<T> Where(Func<T,bool> predicate)
            => Seq.indexed(from x in Data where predicate(x) select x);

        public static IndexedSeq<T> Default 
            => new IndexedSeq<T>(default(T));

        [MethodImpl(Inline)]
        static T[] Conform(T[] src)
            => src == null || src.Length == 0 ? Root.array<T>(default(T)) : src;

    }
}