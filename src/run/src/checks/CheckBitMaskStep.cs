//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [Step]
    public readonly struct CheckBitMasksStep : IWfStep<CheckBitMasksStep>
    {
        public static WfStepId StepId
            => Flow.step<CheckBitMasksStep>();
    }
}