//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static z;
    using static Flow;

    using Asm;

    [Step]
    public sealed class ClearCaptureArchivesHost : WfHost<ClearCaptureArchivesHost>
    {
        public static WfStepId StepId
            => step<ClearCaptureArchivesHost>();
    }

}