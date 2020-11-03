//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using static Konst;
    using static z;

    [Free]
    public delegate CmdResult CmdWorkerFunction(IWfShell wf, CmdSpec cmd);

    [Free]
    public delegate CmdResult CmdWorkerFunction<C>(IWfShell wf, C cmd)
        where C : struct, ICmdSpec<C>;
}