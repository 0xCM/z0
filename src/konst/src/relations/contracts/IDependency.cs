//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static Rules;

    /// <summary>
    /// Characterizes a directed relation from a source to a target
    /// </summary>
    /// <typeparam name="S">The source node type</typeparam>
    /// <typeparam name="T">The target node type</typeparam>
    public interface IRelation<S,T>
        where S : INode<S>
        where T : INode<T>
    {
        S Source {get;}

        T Target {get;}
    }

    /// <summary>
    /// Characterizes a kinded relation
    /// </summary>
    /// <typeparam name="K">The kind type</typeparam>
    /// <typeparam name="S">The source node type</typeparam>
    /// <typeparam name="T">The target node type</typeparam>
    public interface IRelation<K,S,T> : IRelation<S,T>, IKinded<K>
        where K : unmanaged
        where S : INode<S>
        where T : INode<T>
    {

    }

    /// <summary>
    /// Characterizes a depency relation from a source to a target
    /// </summary>
    /// <typeparam name="S">The source node type</typeparam>
    /// <typeparam name="T">The target node type</typeparam>
    public interface IDependency<S,T> : IRelation<S,T>
        where S : INode<S>
        where T : INode<T>
    {
    }

    /// <summary>
    /// Characterizes a depency relation between nodes of heterogeneous type
    /// </summary>
    /// <typeparam name="T">The node type</typeparam>
    public interface IDependency<T> : IDependency<T,T>
        where T : INode<T>
    {
    }
}