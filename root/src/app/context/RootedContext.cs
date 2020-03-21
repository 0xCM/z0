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
    public interface IRootedContext<R> : IAppContext
        where R : IAppContext
    {
        R Root {get;}
    }

    public interface IRootContext<R,D> : IAppContext
        where R : IAppContext
        where D : IRootedContext<R>
    {
        D Descendant {get;}
    }

    

}