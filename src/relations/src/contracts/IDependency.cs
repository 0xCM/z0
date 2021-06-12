//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IDependency : IRelation
    {

    }

    /// <summary>
    /// Characterizes a depency relation from a source to a target
    /// </summary>
    /// <typeparam name="S">The source node type</typeparam>
    /// <typeparam name="T">The target node type</typeparam>
    [Free]
    public interface IDependency<K,S,T> : IDependency, IRelation<K,S,T>
        where K : IDependency<K,S,T>
    {
        K IRelation<K,S,T>.Kind => (K)this;
    }

    /// <summary>
    /// Characterizes a depency relation between nodes of heterogeneous type
    /// </summary>
    /// <typeparam name="T">The node type</typeparam>
    [Free]
    public interface IDependency<K,T> : IDependency<K,T,T>
        where K : IDependency<K,T>
    {

    }
}