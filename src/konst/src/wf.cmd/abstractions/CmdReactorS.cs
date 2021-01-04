//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [CmdReactor]
    public abstract class CmdReactor<S> : ICmdReactor<S>
        where S : struct, ICmdSpec
    {
        protected WfHost Host;

        protected IWfShell Wf;

        protected IWfDb Db => Wf.Db();

        public static S Spec() => new S();

        public CmdId CmdId => Spec().CmdId;

        protected abstract CmdResult Run(S cmd);

        public CmdResult<S> Invoke(S cmd)
        {
            try
            {
                var result = Run(cmd);
                return new CmdResult<S>(cmd, result.Succeeded, result.Message);
            }
            catch(Exception e)
            {
                Wf.Error(e);
                return new CmdResult<S>(cmd, e);
            }
        }

        CmdResult ICmdReactor.Invoke(ICmdSpec src)
            => Invoke((S)src);

        public void Init(IWfShell wf)
        {
            Host = WfShell.host(GetType());
            Wf = wf.WithHost(Host);
        }
    }
}