//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Konst;
    
    [Step(true)]
    public readonly struct ExtractMembersStep
    {
        public const WfStepKind StepId = WfStepKind.ExtractMembers;
        
        public const string WorkerName = nameof(ExtractMembers);
    }
}