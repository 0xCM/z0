//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IApiHost<F> : IApiHost
        where F : IApiHost<F>, new()
    {
        Type IApiHost.HostType 
            => typeof(F);                
    }
}