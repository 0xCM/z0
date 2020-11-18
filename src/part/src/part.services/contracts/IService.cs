//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes nothing but is a marker for a type that, perhaps, defines something useful to someone
    /// </summary>
    [Free]
    public interface IService
    {

    }

    /// <summary>
    /// Characterizes a service that extends a parametric context with operational semantics.
    /// </summary>
    /// <typeparam name="C">The context type</typeparam>
    [Free]
    public interface IService<C> : IService, IContextual<C>
    {

    }
}