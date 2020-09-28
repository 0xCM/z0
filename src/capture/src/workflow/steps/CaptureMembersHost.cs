//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static z;
    using static Flow;

    [Step]
    public sealed class CaptureMembersHost : WfHost<CaptureMembersHost>
    {
        public static WfStepId StepId
            => step<CaptureMembersHost>();
    }
}