//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    [CmdReactor]
    public abstract class CmdReactor<S> : ICmdReactor<S>
        where S : struct, ICmdSpec<S>
    {
        protected WfHost Host;

        protected IWfShell Wf;

        protected IFileDb Db => Wf.Db();

        public static S Spec() => new S();

        public CmdId CmdId => Spec().CmdId;

        protected abstract CmdResult Run(S cmd);

        public CmdResult Invoke(S cmd)
        {
            try
            {
                return Run(cmd);
            }
            catch(Exception e)
            {
                Wf.Error(e);
                return new CmdResult(cmd.CmdId, false);
            }
        }

        public void Init(IWfShell wf)
        {
            Host = WfShell.host(GetType());
            Wf = wf.WithHost(Host);
        }
    }
}