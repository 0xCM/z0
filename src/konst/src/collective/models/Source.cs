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
    /// Defines a LINQ-monadic cover for a deferred finite or infinite parametric sequence
    /// </summary>
    public readonly struct Source<T> : IDeferred<Source<T>,T>
    {
        readonly IEnumerable<T> E;

        [MethodImpl(Inline)]
        public Source(IEnumerable<T> src)
            => E = src;

        public readonly IEnumerable<T> Content
        {
            [MethodImpl(Inline)]
            get => E;
        }

        [MethodImpl(Inline)]
        public static Source<T> operator + (Source<T> lhs, Source<T> rhs)
            => lhs.Concat(rhs);

        /// <summary>
        /// Implicitly constructs a sequence from an array
        /// </summary>
        /// <param name="src">The source array</param>
        public static implicit operator Source<T>(T[] src)
            => new Source<T>(src);

        [MethodImpl(Inline)]
        public Source<T> WithContent(IEnumerable<T> src)
            => new Source<T>(src);

        public Source<T> Concat(Source<T> rhs)
            => new Source<T>(Content.Concat(rhs.Content));

        public Source<Y> Select<Y>(Func<T,Y> selector)
             => from(from x in Content select selector(x));

        public Source<Z> SelectMany<Y,Z>(Func<T,Source<Y>> lift, Func<T,Y,Z> project)
            => from(from x in Content
                          from y in lift(x).Content
                          select project(x, y));

        public Source<Y> SelectMany<Y>(Func<T,Source<Y>> lift)
            => from(from x in Content
                          from y in lift(x).Content
                          select y);

        public Source<T> Where(Func<T,bool> predicate)
            => from(from x in Content where predicate(x) select x);

        public static Source<T> Empty
            => new Source<T>(sys.empty<T>());
    }
}