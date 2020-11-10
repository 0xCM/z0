//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

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
}