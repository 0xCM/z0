//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Konst;

    [Step(true)]
    public readonly struct ExtractHostMembersStep
    {
        public const WfStepKind StepId = WfStepKind.ExtractHostMembers;

        public const string WorkerName = nameof(ExtractHostMembers);
    }
}