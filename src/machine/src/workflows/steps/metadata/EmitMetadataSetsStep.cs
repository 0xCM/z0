//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;     
    using static Flow;

    [Step(WfStepKind.EmitMetadataSets, true)]
    public readonly struct EmitMetadataSetsStep
    {
        public const string WorkerName = nameof(EmitMetadataSets);
    }
}