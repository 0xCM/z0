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

    public abstract class CmdHost<H,C> : WfHost<H>
        where H : CmdHost<H,C>, new()
        where C : struct, ICmdSpec<C>
    {
        public CmdId CmdId => new C().Id;

        protected static C Spec() => new C();

        protected static CmdResult Fail(params byte[] data)
            => new CmdResult(new CmdId(), false, data);

        protected static CmdResult Win(params byte[] data)
            => new CmdResult(new CmdId(), true, data);

        public CmdResult Run(IWfShell wf, in C spec)
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

        protected abstract CmdResult Execute(IWfShell wf, in C spec);

        protected override void Execute(IWfShell wf)
            => Execute(wf, Spec());

        public virtual CmdResult Run(IWfShell wf, CmdSpec spec)
        {
            return Execute(wf, Spec());
        }
    }
}