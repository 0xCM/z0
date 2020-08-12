//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Security;


    [SuppressUnmanagedCodeSecurity]
    public interface IWfActor : IWfWorker, IDisposable
    {
        
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IWfActor<H> : IWfActor
        where H : struct, IWfActor<H>
    {
        
    }
}