//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;    

    /// <summary>
    /// Characterizes a type that defines something useful to someone
    /// </summary>
    /// <remarks>
    /// The only point of this apparently meaningless interface is that the language is
    /// unable to express/describe operational semantics in the absence of state. So,
    /// take a readonly struct carries no state, reify a specialize of this interface,
    /// and have contractualized stateless operations that live at the instance level
    /// in the mind of the CLR
    /// </remarks>
    public interface IService
    {
        
    }
    
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

    /// <summary>
    /// Characterizes a service that extends a parametric context with operational semantics. 
    /// </summary>
    /// <typeparam name="C">The context type</typeparam>
    public interface IService<C> : IService, IContextual<C>
    {
        
    }

    /// <summary>
    /// Characterizes a stateless service that requires explicit resource management
    /// </summary>
    /// </remarks>
    /// Read the summary again
    /// </remarks>
    public interface IServiceAllocation : IService, IDisposable
    {

    }

    /// <summary>
    /// Characterizes a stateful service that requires explcit resource managment
    /// </summary>
    /// <typeparam name="C">The context type</typeparam>
    public interface IServiceAllocation<C> : IContextual<C>, IServiceAllocation
    {
        
    }
}