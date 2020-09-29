//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
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