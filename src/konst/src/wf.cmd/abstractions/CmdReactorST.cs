//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [CmdReactor]
    public abstract class CmdReactor<S,T> : ICmdReactor<S,T>
        where S : struct, ICmdSpec<S>
        where T : struct
    {
        protected WfHost Host;

        protected IWfShell Wf;

        protected IWfDb Db => Wf.Db();

        public static S Spec() => new S();

        public CmdId CmdId => Spec().CmdId;

        protected abstract T Run(S cmd);

        public CmdResult<T> Invoke(S cmd)
        {
            try
            {
                return new CmdResult<T>(cmd.CmdId, true, Run(cmd));
            }
            catch(Exception e)
            {
                Wf.Error(e);
                return new CmdResult<T>(cmd.CmdId, e);
            }
        }

        public void Init(IWfShell wf)
        {
            Host = WfShell.host(GetType());
            Wf = wf.WithHost(Host);
        }
    }
}