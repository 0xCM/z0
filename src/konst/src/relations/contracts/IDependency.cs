//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes a depency relation from a source to a target
    /// </summary>
    /// <typeparam name="S">The source node type</typeparam>
    /// <typeparam name="T">The target node type</typeparam>
    [Free]
    public interface IDependency<S,T> : IRelation<S,T>
        where S : INode<S>
        where T : INode<T>
    {
    }

    /// <summary>
    /// Characterizes a depency relation between nodes of heterogeneous type
    /// </summary>
    /// <typeparam name="T">The node type</typeparam>
    [Free]
    public interface IDependency<T> : IDependency<T,T>
        where T : INode<T>
    {
    }
}