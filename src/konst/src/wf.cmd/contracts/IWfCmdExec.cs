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

    public interface IWfCmdExec
    {

    }

    public sealed class WfCmdHost : WfHost<WfCmdHost>
    {

    }

    public interface IWfCmdExec<C,R> : IWfCmdExec
        where C : struct
        where R : struct
    {

        Outcome<R> Run(IWfShell wf, C spec);
    }

   public interface IWfCmdExec<H,C,R> : IWfCmdExec<C,R>
        where C : struct
        where R : struct
        where H : IWfCmdExec<H,C,R>, new()
    {

    }
}