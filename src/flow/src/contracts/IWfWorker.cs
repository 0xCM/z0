//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface IWfWorker
    {
        IWfContext Wf {get;}
    }

    public interface IWfWorker<H> : IWfWorker
        where H : struct, IWfWorker<H>
    {

    }
}