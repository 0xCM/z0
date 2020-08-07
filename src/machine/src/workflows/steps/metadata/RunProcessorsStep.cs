//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static Flow;

    [Step(Kind, true)]
    public readonly struct RunProcessorsStep
    {
        public const WfStepKind Kind = WfStepKind.RunProcessors;
        
        public const string Name = nameof(RunProcessors);    

        public static WfStepId Id => step(Kind, Name);
    }
}