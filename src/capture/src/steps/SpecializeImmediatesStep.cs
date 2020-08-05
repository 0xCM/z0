//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Konst;


    [Step(true)]
    public readonly struct SpecializeImmediatesStep
    {
        public const WfStepId StepId = WfStepId.SpecializeImmediates;

        public const string WorkerName = nameof(SpecializeImmediates);
    }
}