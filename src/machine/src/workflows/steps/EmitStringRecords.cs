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
    public sealed class EmitStringRecords : WfHost<EmitStringRecords>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitStringRecordsStep(wf,this);
            step.Run();
        }
    }
}