//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using static Konst;
    using static z;

    [Free]
    public interface ICmdWorker
    {
        CmdResult Invoke(IWfShell wf, CmdSpec cmd);
    }

    [Free]
    public interface ICmdWorkerHost<H> : ICmdWorker
        where H : ICmdWorkerHost<H>
    {

    }

    [Free]
    public interface ICmdWorker<C> : ICmdWorker
        where C : struct, ICmdSpec<C>
    {
        CmdResult Invoke(IWfShell wf, C cmd);
    }

    [Free]
    public interface ICmdWorkerHost<H,C> : ICmdWorker<C>
        where C : struct, ICmdSpec<C>
        where H : ICmdWorkerHost<H,C>
    {

    }
}