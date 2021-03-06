//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes semiring operations
    /// </summary>
    /// <typeparam name="T">The individual type</typeparam>
    public interface ISemiringOps<T> : IMonoidAOps<T>, IMonoidMOps<T>, IDistributiveOps<T>
        where T : unmanaged
    {
        T MulAdd(T x, T y, T z);
    }

    /// <summary>
    /// Characterizes a semiring structure
    /// </summary>
    /// <typeparam name="S">The structure type</typeparam>
    public interface ISemiring<S> : IMonoidA<S>, IMonoidM<S>, IDistributive<S>
        where S : ISemiring<S>, new()
     {
        S MulAdd(S y, S z);
     }
}