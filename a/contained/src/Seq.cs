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

    using static Seed;    
    using static Seq;

    /// <summary>
    /// Provides a layer of indirection for, and gives a concrete type to, an IEnumerable instance
    /// </summary>
    public readonly struct Seq<T> : ISeq<Seq<T>,T>
    {
        public static readonly Seq<T> Empty = default;

        [MethodImpl(Inline)]   
        public static Seq<T> operator + (Seq<T> lhs, Seq<T> rhs)
            => lhs.Concat(rhs);

        /// <summary>
        /// Implicitly constructs a sequence from an array
        /// </summary>
        /// <param name="src">The source array</param>
        public static implicit operator Seq<T>(T[] src)
            => new Seq<T>(src);

        public Seq(IEnumerable<T> src)
        {
            this.Source = src;
            this.nonempty = true;
        }

        readonly IEnumerable<T> Source;
        
        readonly bool nonempty;

        public IEnumerable<T> Content 
            => Source;

        public bool empty()
            => !nonempty;

        public Seq<T> redefine(IEnumerable<T> src)
            => new Seq<T>(src);

        public Seq<T> Concat(Seq<T> rhs)
            => new Seq<T>(Source.Concat(rhs.Source));

        public Seq<Y> Select<Y>(Func<T, Y> selector)       
             => define(from x in Source select selector(x));

        public Seq<Z> SelectMany<Y, Z>(Func<T, Seq<Y>> lift, Func<T, Y, Z> project)
            => define(from x in Source
                          from y in lift(x).Source
                          select project(x, y));

        public Seq<Y> SelectMany<Y>(Func<T, Seq<Y>> lift)
            => define(from x in Source
                          from y in lift(x).Source
                          select y);

        public Seq<T> Where(Func<T, bool> predicate)
            => define(from x in Source where predicate(x) select x);
    }
}