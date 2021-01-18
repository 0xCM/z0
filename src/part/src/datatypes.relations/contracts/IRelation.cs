//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    public interface IRelation
    {
        dynamic Source {get;}

        dynamic Target {get;}
    }

    /// <summary>
    /// Characterizes a directed relation from a source to a target
    /// </summary>
    /// <typeparam name="S">The source node type</typeparam>
    /// <typeparam name="T">The target node type</typeparam>
    [Free]
    public interface IRelation<S,T> : IRelation
    {
        new S Source {get;}

        new T Target {get;}

        dynamic IRelation.Source
            => Source;

        dynamic IRelation.Target
            => Target;
    }
}