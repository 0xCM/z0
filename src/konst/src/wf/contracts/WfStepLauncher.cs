//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free =System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public delegate void WfStepLauncher(IWfShell wf);

    [Free]
    public delegate void WfStepLauncher<H>(IWfShell wf, H host)
        where H : IWfHost<H>,new();

}