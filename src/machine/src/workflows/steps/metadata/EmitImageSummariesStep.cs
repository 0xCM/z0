//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static Flow;

    [Step(Kind, true)]
    public readonly struct EmitImageSummariesStep
    {
        public const WfStepKind Kind = WfStepKind.EmitImageSummaries;

        public const string Name = nameof(EmitImageSummaries);

        public static WfStepId Id => step(Kind, Name);
    }
}