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

    [WfCmd]
    public abstract class CmdExec<C,R> : ICmdExec<C,R>
        where C : struct
        where R : struct
    {

        readonly CmdHost Host;

        protected CmdExec()
        {
            Host = new CmdHost();
        }

        protected abstract R Execute(IWfShell wf, C spec);

        public Outcome<R> Run(IWfShell wf, C spec)
        {
            try
            {
                return Execute(wf, spec);
            }
            catch(Exception e)
            {
                wf.Error(Host, e);
                return e;
            }
        }

    }

    public abstract class CmdExec<H,C,R> : CmdExec<C,R>
        where H : CmdExec<H,C,R>, new()
        where C : struct
        where R : struct
    {

    }
}