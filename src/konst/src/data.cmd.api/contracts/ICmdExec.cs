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

    public interface ICmdExec
    {

    }

    public interface ICmdExec<C,R> : ICmdExec
        where C : struct
        where R : struct
    {

        Outcome<R> Run(IWfShell wf, C spec);
    }

   public interface ICmdExec<H,C,R> : ICmdExec<C,R>
        where C : struct
        where R : struct
        where H : ICmdExec<H,C,R>, new()
    {

    }
}