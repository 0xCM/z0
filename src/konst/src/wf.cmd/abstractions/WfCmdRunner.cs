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

    public abstract class WfCmdRunner<C,R> : IWfCmdRunner<C,R>
        where C : struct
        where R : struct
    {

        readonly WfCmdHost Host;

        protected WfCmdRunner()
        {
            Host = new WfCmdHost();
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

    public abstract class WfCmdRunner<H,C,R> : WfCmdRunner<C,R>
        where H : WfCmdRunner<H,C,R>, new()
        where C : struct
        where R : struct
    {


    }
}