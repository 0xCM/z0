//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public interface ISemigroupAOps<T> : ISemigroupOps<T>, IAdditiveOps<T>
    {

    }

    public interface ISemigroupMOps<T> : ISemigroupOps<T>, IMultiplicativeOps<T>
    {

    }

    public interface ISemigroupM<T>: ISemigroup<T>, IMultiplicative<T>
    {

    }

    public interface ISemigroupA<T>: ISemigroup<T>, IAdditive<T>
    {

    }


    public interface ISemigroupA<S,T> : ISemigroupA<T>
        where S : ISemigroupA<S,T>, new()
    {

    }

    public interface ISemigroupM<S,T> : ISemigroup<T>, IMultiplicative<T>
        where S : ISemigroupM<S,T>, new()
    {

    }

    public interface IImplicitSemigroup<S,T> : INullary<S>, ISemigroup<S>, INullaryOps<T>, ISemigroupOps<T>
        where S : IImplicitSemigroup<S,T>, new()
        where T : unmanaged

    {
        /// <summary>
        /// Gets an equality comparer that can determine whether to semigroup elements are equal
        /// </summary>
        /// <param name="hasher">The hash function to use, if specified</param>
        IEqualityComparer<T> Comparer(Func<T,int> hasher = null);
    }
}