//-------------------------------------------------------------------------------------------
// MetaCore
// Author: Chris Moore, 0xCM@gmail.com
// License: MIT
//-------------------------------------------------------------------------------------------
namespace Meta.Core
{
    using System;
    using System.Linq;

    using static minicore;

    using Modules;

    public interface IIndexAlt<X> : IAlt<X, IndexImmutable<X>> { }

    public interface IIndexBind<X, Y> : IBind<X, IndexImmutable<X>, IndexImmutable<Func<X, Y>>, Y, IndexImmutable<Y>> { }

    public interface IIndexFunctor<X, Y> : IFunctor<X, IndexImmutable<X>, Y, IndexImmutable<Y>> { }

    public interface IIndexMonoid<X> : IMonoid<IndexImmutable<X>> { }

    partial class Index
    {
        readonly struct IndexAlt<X> : IIndexAlt<X>
        {
            public static readonly IndexAlt<X> instance = default;

            public IndexImmutable<X> alt(IndexImmutable<X> s1, IndexImmutable<X> s2)
                => IndexImmutable.concat(s1, s2);

            public Func<IndexImmutable<X>, IndexImmutable<X>> fmap(Func<X, X> f)
                => IndexImmutable.fmap(f);
        }

        readonly struct IndexMonoid<X> : IIndexMonoid<X>
        {
            public static readonly IndexMonoid<X> instance = default;

            public IndexImmutable<X> zero
                => IndexImmutable<X>.Empty;

            public IndexImmutable<X> combine(IndexImmutable<X> a1, IndexImmutable<X> a2)
                => a1 + a2;

            public bool eq(IndexImmutable<X> x1, IndexImmutable<X> x2)
                => x1 == x2;
        }

        readonly struct IndexBind<X, Y> : IIndexBind<X, Y>
        {
            public static readonly IndexBind<X, Y> instance = default;

            /// <summary>
            /// Applies a Index of function to a Index of values
            /// </summary>
            public IndexImmutable<Y> apply(IndexImmutable<Func<X, Y>> lf, IndexImmutable<X> lx)
                => IndexImmutable.apply(lf, lx);

            public IndexImmutable<Y> bind(IndexImmutable<X> index, Func<X, IndexImmutable<Y>> f)
                => IndexImmutable.bind(index, f);

            public Func<IndexImmutable<X>, IndexImmutable<Y>> fmap(Func<X, Y> f)
                => IndexImmutable.fmap(f);
        }

        /// <summary>
        /// Defines an <see cref="IFunctor"/> instance for <see cref="IIndex"/>
        /// </summary>
        /// <typeparam name="X">The source type</typeparam>
        /// <typeparam name="Y">The target type</typeparam>
        readonly struct IndexFunctor<X, Y> : IIndexFunctor<X, Y>
        {
            public static readonly IndexFunctor<X, Y> instance = default;

            public Func<IndexImmutable<X>, IndexImmutable<Y>> fmap(Func<X, Y> f)
                => IndexImmutable.fmap(f);
        }

    }
}