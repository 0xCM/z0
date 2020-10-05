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

    [WfHost]
    public sealed class EmitLocatedPartsHost : WfHost<EmitLocatedPartsHost>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitLocatedParts(wf, this);
            step.Run();
        }
    }
}