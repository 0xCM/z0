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
    using static Seq;

    /// <summary>
    /// Refies a canonical sequence container with content that need not be finite
    /// </summary>
    public readonly struct Seq<T> : ISeq<Seq<T>,T>
    {
        public static readonly Seq<T> Empty = new Seq<T>(Root.array<T>());

        public IEnumerable<T> Content {get;}

        [MethodImpl(Inline)]   
        public static Seq<T> operator + (Seq<T> lhs, Seq<T> rhs)
            => lhs.Concat(rhs);

        /// <summary>
        /// Implicitly constructs a sequence from an array
        /// </summary>
        /// <param name="src">The source array</param>
        public static implicit operator Seq<T>(T[] src)
            => new Seq<T>(src);

        [MethodImpl(Inline)]   
        public Seq(IEnumerable<T> src)
        {
            Content = src;
        }

        [MethodImpl(Inline)]
        public Seq<T> WithContent(IEnumerable<T> src)
            => new Seq<T>(src);

        public Seq<T> Concat(Seq<T> rhs)
            => new Seq<T>(Content.Concat(rhs.Content));

        public Seq<Y> Select<Y>(Func<T,Y> selector)       
             => define(from x in Content select selector(x));

        public Seq<Z> SelectMany<Y,Z>(Func<T,Seq<Y>> lift, Func<T,Y,Z> project)
            => define(from x in Content
                          from y in lift(x).Content
                          select project(x, y));

        public Seq<Y> SelectMany<Y>(Func<T,Seq<Y>> lift)
            => define(from x in Content
                          from y in lift(x).Content
                          select y);

        public Seq<T> Where(Func<T,bool> predicate)
            => define(from x in Content where predicate(x) select x);
    }
}