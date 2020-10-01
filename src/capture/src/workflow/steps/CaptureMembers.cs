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
    public sealed class CaptureMembers : WfHost<CaptureMembers>
    {
        public static WfStepId StepId
            => step<CaptureMembers>();
    }
}