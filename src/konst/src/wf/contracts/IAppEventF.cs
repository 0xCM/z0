//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    /// <summary>
    /// Characterizes a reified application event
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IAppEvent<F> : IAppEvent, INullary<F>, ICorrelated<F>, IChronic<F>
        where F : struct, IAppEvent<F>
    {
        F INullary<F>.Zero 
            => default;
    }
    
    [SuppressUnmanagedCodeSecurity]
    public interface IAppEvent<F,T> : IAppEvent<F>
        where F : struct, IAppEvent<F,T>
    {
        T Data {get;}
    }
}