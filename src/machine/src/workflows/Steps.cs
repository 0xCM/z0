//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    using static Flow;
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
    public class ProcessPartFilesHost : WfHost<ProcessPartFilesHost,IAsmContext>
    {
        protected override void Execute(IWfShell<IAsmContext> wf)
        {
            using var step = new ProcessPartFiles(wf.Shell, wf.State, wf.Ct);
            step.Run();
        }
    }

    [WfHost]
    public sealed class CaptureResBytesHost : WfHost<CaptureResBytesHost>
    {

    }


    [Step]
    public readonly struct EmitPartStringsStep : IWfStep<EmitPartStringsStep>
    {
        public const string EmissionType = EmitStringRecordsHost.DataType;

        public static WfStepId StepId
            => Flow.step<EmitPartStringsStep>();

        public static string ExtName(PartStringKind kind)
            => (kind == PartStringKind.System ? EmitStringRecordsHost.SystemKindExt : EmitStringRecordsHost.UserKindExt).ToLower();
    }



    [Step]
    public sealed class EmitStepListStep : IWfStep<EmitStepListStep>
    {

    }
}