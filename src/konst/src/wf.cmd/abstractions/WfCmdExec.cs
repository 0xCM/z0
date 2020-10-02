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

    public class WfCmdAttribute : Attribute
    {


    }

    [WfCmd]
    public abstract class WfCmdExec<C,R> : IWfCmdExec<C,R>
        where C : struct
        where R : struct
    {

        readonly WfCmdHost Host;

        protected WfCmdExec()
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

    public abstract class WfCmdExec<H,C,R> : WfCmdExec<C,R>
        where H : WfCmdExec<H,C,R>, new()
        where C : struct
        where R : struct
    {


    }
}