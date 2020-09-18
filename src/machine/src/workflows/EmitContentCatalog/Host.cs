//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    [WfHost]
    public sealed class EmitContentCatalogHost : WfHost<EmitContentCatalogHost>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitContentCatalog(wf,this);
            step.Run();
        }
    }
}