//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IAdditiveSemigroup<T>: ISemigroup<T>, IAdditive<T>
    {

    }

    public interface IAdditiveSemigroupA<S,T> : IAdditiveSemigroup<T>
        where S : IAdditiveSemigroupA<S,T>, new()
    {

    }

}