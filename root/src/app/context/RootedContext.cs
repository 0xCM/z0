//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;


    /// <summary>
    /// Defines a context that is predicated on an existing context
    /// </summary>
    /// <typeparam name="R">The root context type</typeparam>
    public interface IRootedContext<R> : IContext
        where R : IContext
    {
        R Root {get;}
    }

    public interface IRootContext<R,D> : IContext
        where R : IContext
        where D : IRootedContext<R>
    {
        D Descendant {get;}
    }

    

}