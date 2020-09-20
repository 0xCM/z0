//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public sealed class CheckCreditsHost : WfHost<CheckCreditsHost>
    {
        public static WfStepId StepId
            => typeof(CheckCreditsHost);
    }
}