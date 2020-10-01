//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static z;
    using static WfCore;

    [Step]
    public sealed class EvaluateStep : WfHost<EvaluateStep>
    {
        public static WfStepId StepId
            => step<EvaluateStep>();
    }

    [Step]
    public sealed class SpecializeImm : WfHost<SpecializeImm>
    {
        public static WfStepId StepId
            => WfCore.step<SpecializeImm>();
    }


}