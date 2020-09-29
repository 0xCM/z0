//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static z;


    [WfHost]
    public sealed class MachineControl : WfHost<MachineControl>
    {
    }


    [WfHost]
    public class RecaptureHost : WfHost<RecaptureHost>
    {


    }

    [WfHost]
    public sealed class EmitDatasetsHost : WfHost<EmitDatasetsHost>
    {

    }

    [WfHost]
    public class CreateGlobalIndexHost : WfHost<CreateGlobalIndexHost>
    {
        public override void Run(IWfShell shell)
            => throw missing();
    }


    [WfHost]
    public sealed class CaptureResBytesHost : WfHost<CaptureResBytesHost>
    {

    }

    [Step]
    public sealed class EmitStepListStep : IWfStep<EmitStepListStep>
    {

    }
}