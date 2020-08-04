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
        public const WfStepId StepId = WfStepId.ExtractHostMembers;

        public const string WorkerName = nameof(ExtractHostMembers);
    }
}