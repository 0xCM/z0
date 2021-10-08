//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IAdditive<T>
    {
        T Add(T src);
    }

    /// <summary>
    /// Characterizes a structure that supports semigroup additivity
    /// </summary>
    /// <typeparam name="S">The structure type</typeparam>
    public interface IAdditive<F,T> : IAdditive<T>, ICommutative<T>
        where F : IAdditive<F,T>, new()
    {
    }
}