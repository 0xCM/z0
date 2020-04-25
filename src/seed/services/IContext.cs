//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;    

    /// <summary>
    /// Charaterizes a shared execution environment that may be stateful or stateless
    /// </summary>
    public interface IContext
    {
        static IContext Default => default(DefaultContext);
    }

    readonly struct DefaultContext : IContext
    {

    }

    /// <summary>
    /// Charaterizes a component that maintains readonly-access to encapsulated state, here and throughout referred to as a context
    /// </summary>
    public interface IContextual<C>
    {
        C Context {get;}
    }    

    /// <summary>
    /// Charaterizes a stateful shared execution environment over a parametric context
    /// </summary>
    /// <typeparam name="C">The context type</typeparam>
    public interface IContext<C> : IContext, IContextual<C>
    {

    }
}