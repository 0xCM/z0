//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public delegate CmdResult CmdWorkerFunction(IWfShell wf, CmdSpec cmd);

    [Free]
    public delegate CmdResult CmdWorkerFunction<C>(IWfShell wf, C cmd)
        where C : struct, ICmdSpec<C>;

    [Free]
    public interface ICmdWorker
    {
        CmdId CmdId {get;}

        CmdResult Invoke(IWfShell wf, CmdSpec cmd);
    }

    [Free]
    public interface ICmdWorkerHost<H> : ICmdWorker
        where H : ICmdWorkerHost<H>
    {

    }

    [Free]
    public interface ICmdRunner
    {
        CmdId CmdId {get;}
    }

    [Free]
    public interface ICmdRunner<C> : ICmdRunner
        where C : struct, ICmdSpec<C>
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