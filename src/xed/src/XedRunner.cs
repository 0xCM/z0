//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;


    using Z0.Xed;


    public sealed class XedEtlWfHost : WfHost<XedEtlWfHost>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = XedEtlWf.create(wf);
            step.Run();
        }
    }

}