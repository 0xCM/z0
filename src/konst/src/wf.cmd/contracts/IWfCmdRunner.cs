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

    public interface IWfCmdRunner
    {

    }

    public sealed class WfCmdHost : WfHost<WfCmdHost>
    {

    }

    public interface IWfCmdRunner<C,R> : IWfCmdRunner
        where C : struct
        where R : struct
    {

        Outcome<R> Run(IWfShell wf, C spec);
    }

   public interface IWfCmdRunner<H,C,R> : IWfCmdRunner<C,R>
        where C : struct
        where R : struct
        where H : IWfCmdRunner<H,C,R>, new()
    {

    }
}