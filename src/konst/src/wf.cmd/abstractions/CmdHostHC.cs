//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public abstract class CmdHost<H,S> : WfHost<H>
        where H : CmdHost<H,S>, new()
        where S : struct, ICmdSpec<S>
    {
        public CmdId CmdId => new S().Id;

        protected static S Spec() => new S();

        protected static CmdResult Fail(params byte[] data)
            => new CmdResult(new CmdId(), false, data);

        protected static CmdResult Win(params byte[] data)
            => new CmdResult(new CmdId(), true, data);

        public CmdResult Run(IWfShell wf, in S spec)
        {
            try
            {
                wf = wf.WithHost(this);
                wf.Running(this);
                var result = Execute(wf, spec);
                wf.Ran(result);
                return result;
            }
            catch(Exception e)
            {
                wf.Error(e);
                return Fail();
            }
        }

        protected abstract CmdResult Execute(IWfShell wf, in S spec);

        protected override void Execute(IWfShell wf)
            => Execute(wf, Spec());

        public virtual CmdResult Run(IWfShell wf, CmdSpec spec)
        {
            return Execute(wf, Spec());
        }
    }
}