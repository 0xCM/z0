//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static Konst;

    [Step]
    public sealed class EmitEnumCatalogHost : WfHost<EmitEnumCatalogHost>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitEnumCatalog(wf, this);
            step.Run();
        }
    }
}