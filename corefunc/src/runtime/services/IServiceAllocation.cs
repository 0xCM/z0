//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using static zfunc;

    /// <summary>
    /// Characterizes a service that requires explicit lifecycle managment
    /// </summary>
    public interface IServiceAllocation : IAppService, IDisposable
    {

    }

    /// <summary>
    /// Characterizes a service with parametric context that requires explicit lifecycle managment
    /// </summary>
    public interface IServiceAllocation<C> : IServiceAllocation, IAppService<C>
        where C : IRngContext
    {

    }
}