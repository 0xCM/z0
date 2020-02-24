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

    using static Root;

    public readonly struct FiniteSeq<T> : IFiniteSeq<FiniteSeq<T>,T>
    {
        public static readonly FiniteSeq<T> Empty = default;

        /// <summary>
        /// Implicitly constructs a sequence from an array
        /// </summary>
        /// <param name="src">The source array</param>
        public static implicit operator FiniteSeq<T>(T[] src)
            => new FiniteSeq<T>(src);

        [MethodImpl(Inline)]
        public FiniteSeq(T[] src)
        {
            this.Source = src;
            this.nonempty = true;
        }

        [MethodImpl(Inline)]
        public FiniteSeq(IEnumerable<T> src)
        {
            this.Source = src.ToArray();
            this.nonempty = true;
        }

        readonly bool nonempty;

        readonly T[] Source;

        public IEnumerable<T> Content
            => Source;

        public int Count 
            => Source.Length;

        public bool empty()
            => !nonempty;

        public T this[int i] 
            => Source[i];

        [MethodImpl(Inline)]
        public bool Equals(FiniteSeq<T> rhs)
            => Source.Equals(rhs.Source);

        public FiniteSeq<T> Concat(FiniteSeq<T> rhs)
            => new FiniteSeq<T>(Source.Concat(rhs.Source));

        public FiniteSeq<Y> Select<Y>(Func<T, Y> selector)       
             => Seq.finite(from x in Source select selector(x));

        public FiniteSeq<Z> SelectMany<Y, Z>(Func<T, FiniteSeq<Y>> lift, Func<T, Y, Z> project)
            => Seq.finite(from x in Source
                          from y in lift(x).Source
                          select project(x, y));

        public FiniteSeq<Y> SelectMany<Y>(Func<T, FiniteSeq<Y>> lift)
            => Seq.finite(from x in Source
                          from y in lift(x).Source
                          select y);

        public FiniteSeq<T> Where(Func<T, bool> predicate)
            => Seq.finite(from x in Source where predicate(x) select x);

    }
}