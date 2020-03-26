//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes a collection of stateless operations. 
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

    public interface IServiceAllocation : IService, IDisposable
    {


    }

    /// <summary>
    /// A stateful service, by definition, extends a state (referred to througout as a context) 
    /// with operational semantics. 
    /// </summary>
    /// <typeparam name="C">The context type</typeparam>
    public interface IService<C> : IService, IContextual<C>
        where C : IContext
    {
        
    }

    /// <summary>
    /// Characterizes a service that requires explcit resource managment
    /// </summary>
    /// <typeparam name="C">The context type</typeparam>
    public interface IServiceAllocation<C> : IContextual<C>, IServiceAllocation
        where C : IContext
    {
        
    }

}