//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;
    using System.Runtime.CompilerServices;

    public readonly struct ParseInstructionsStep : IWfStep<ParseInstructionsStep>
    {
        public static WfStepId StepId
            => typeof(ParseInstructionsStep);
    }
}