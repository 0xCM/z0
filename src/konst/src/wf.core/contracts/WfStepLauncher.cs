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

    public delegate void WfStepLauncher(IWfShell wf);

    public delegate void WfStepLauncher<H>(IWfShell wf, H host)
        where H : IWfHost<H>,new();

}