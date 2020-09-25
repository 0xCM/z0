//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    using static Flow;
    using static z;

    [WfHost]
    public sealed class EmitImageSummariesHost : WfHost<EmitImageSummariesHost>
    {
        public static WfStepId StepId
            => Flow.step<EmitImageSummariesHost>();
    }
}