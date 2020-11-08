//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public delegate CmdResult CmdWorkerFunction(ICmdSpec cmd);

    [Free]
    public delegate CmdResult CmdWorkerFunction<C>(C cmd)
        where C : struct, ICmdSpec<C>;

    [Free]
    public interface ICmdWorker
    {
        CmdId CmdId {get;}

        CmdResult Invoke(ICmdSpec cmd);
    }

    [Free]
    public interface ICmdWorker<C> : ICmdWorker
        where C : struct, ICmdSpec<C>
    {
        CmdResult Invoke(C cmd);

        CmdResult ICmdWorker.Invoke(ICmdSpec cmd)
            => Invoke((C)cmd);
    }

    [Free]
    public interface ICmdWorker<H,C> : ICmdWorker<C>
        where C : struct, ICmdSpec<C>
        where H : ICmdWorker<H,C>
    {

    }
}