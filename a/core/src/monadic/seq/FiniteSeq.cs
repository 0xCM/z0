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

    using static Core;


    public readonly struct FiniteSeq<T> : IIndexedSeq<FiniteSeq<T>, T>
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
            this.Content = src;
            this.nonempty = true;
        }

        [MethodImpl(Inline)]
        public FiniteSeq(IEnumerable<T> src)
        {
            this.Content = src.ToArray();
            this.nonempty = true;
        }

        readonly bool nonempty;

        public T[] Content {get;}

        public int Count 
            => Content.Length;

        IEnumerable<T> IContainer<IEnumerable<T>>.Content 
            => Content;

        public bool empty()
            => !nonempty;

        public T this[int i] 
            => Content[i];

        [MethodImpl(Inline)]
        public bool Equals(FiniteSeq<T> rhs)
            => Content.Equals(rhs.Content);

        public FiniteSeq<T> Concat(FiniteSeq<T> rhs)
            => new FiniteSeq<T>(Content.Concat(rhs.Content));

        public FiniteSeq<Y> Select<Y>(Func<T, Y> selector)       
             => Seq.finite(from x in Content select selector(x));

        public FiniteSeq<Z> SelectMany<Y, Z>(Func<T, FiniteSeq<Y>> lift, Func<T, Y, Z> project)
            => Seq.finite(from x in Content
                          from y in lift(x).Content
                          select project(x, y));

        public FiniteSeq<Y> SelectMany<Y>(Func<T, FiniteSeq<Y>> lift)
            => Seq.finite(from x in Content
                          from y in lift(x).Content
                          select y);

        public FiniteSeq<T> Where(Func<T, bool> predicate)
            => Seq.finite(from x in Content where predicate(x) select x);
    }
}