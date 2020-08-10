//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface IWfActor : IDisposable
    {
        IWfContext Wf {get;}
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IWfActor<T> : IWfActor                
    {
        
    }
}