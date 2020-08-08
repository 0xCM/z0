//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [Step(WfStepKind.EmitProjectDocs, true)]
    public readonly struct EmitProjectDocsStep
    {
        public const string WorkerName = nameof(EmitProjectDocs);
    }

}