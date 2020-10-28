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

    public abstract class CmdHost<H,C,P> : CmdHost<H,C>
        where H : CmdHost<H,C>, new()
        where C : struct, ICmdSpec<C>
        where P : struct
    {
        public CmdResult Run(IWfShell wf, in C spec, out P payload)
        {
            try
            {
                wf = wf.WithHost(this);
                wf.Running(this);
                var result = Execute(wf, spec, out payload);
                wf.Ran(result);
                return result;

            }
            catch(Exception e)
            {
                wf.Error(e);
                payload = default;
                return Fail();
            }
        }

        protected override CmdResult Execute(IWfShell wf, in C spec)
            => Execute(wf, spec, out var _);

        protected abstract CmdResult Execute(IWfShell wf, in C Spec, out P payload);
    }
}