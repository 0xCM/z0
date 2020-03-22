//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IService
    {
        
    }

    /// <summary>
    /// Characterizes a service that requires explicit lifecycle managment
    /// </summary>
    public interface IServiceAllocation : IService, IDisposable
    {

        
    }
}