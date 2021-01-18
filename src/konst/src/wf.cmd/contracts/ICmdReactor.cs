//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICmdReactor
    {
        void Init(IWfShell wf);

        CmdId CmdId {get;}

        CmdResult Invoke(ICmdExecSpec cmd);
    }

    [Free]
    public interface ICmdReactor<C> : ICmdReactor
        where C : struct, ICmdExecSpec
    {
        CmdId ICmdReactor.CmdId
            => default(C).CmdId;

        CmdResult<C> Invoke(C src);
    }

    [Free]
    public interface ICmdReactor<C,T> : ICmdReactor
        where C : struct, ICmdExecSpec
    {
        CmdId ICmdReactor.CmdId
            => default(C).CmdId;

        CmdResult<C,T> Invoke(C Cmd);
    }
}