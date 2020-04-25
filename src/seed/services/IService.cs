//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;    

    /// <summary>
    /// Characterizes nothing but is a marker for a type that, perhaps, defines something useful to someone
    /// </summary>
    public interface IService
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