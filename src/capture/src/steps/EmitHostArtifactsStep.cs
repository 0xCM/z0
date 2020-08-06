//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    [Step(true)]
    public readonly struct EmitHostArtifactsStep
    {
        public const string WorkerName = nameof(EmitHostArtifactsStep);

        public const WfStepId StepId = WfStepId.EmitHostArtifacts;
    }
}