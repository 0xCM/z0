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
    public sealed class EmitPeImageHost : WfHost<EmitPeImageHost>
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
    public sealed class EmitFieldMetadataHost : WfHost<EmitFieldMetadataHost>
    {
        public const string StepName = nameof(EmitFieldMetadata);

        public override string Identifier => StepName;

        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitFieldMetadata(wf, this);
            step.Run();
        }
    }


    [WfHost]
    public class CreateGlobalIndexHost : WfHost<CreateGlobalIndexHost>
    {
        public override void Run(IWfShell shell)
            => throw missing();
    }

    [Step]
    public readonly struct ProcessInstructionsStep : IWfStep<ProcessInstructionsStep>
    {
        public static WfStepId StepId
            => step<ProcessInstructionsStep>();
    }

    [WfHost]
    public class ProcessPartFilesHost : WfHost<ProcessPartFilesHost,IAsmContext>
    {
        public override void Run(IWfShell<IAsmContext> wf)
        {
            using var step = new ProcessPartFiles(wf.Shell, wf.Context, wf.Ct);
            step.Run();
        }
    }

    [WfHost]
    public sealed class CaptureResBytesHost : WfHost<CaptureResBytesHost>
    {

    }


    [Step]
    public readonly struct ProcessAsmStep : IWfStep<ProcessAsmStep>
    {
        public static WfStepId StepId
            => step<ProcessAsmStep>();
    }


    [Step]
    public readonly struct EmitPeHeadersStep : IWfStep<EmitPeHeadersStep>
    {
        public static WfStepId StepId
            => step<EmitPeHeadersStep>();
    }


    [Step]
    public sealed class EmitImageConstantsStep : WfHost<EmitImageConstantsStep>
    {
        public static WfStepId StepId
            => step<EmitImageConstantsStep>();
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
    public sealed class EmitImageBlobsHost : WfHost<EmitImageBlobsHost>
    {
        public const string EmissionType = "Metablobs";

        public static WfStepId StepId
            => Flow.step<EmitBitMasksHost>();
    }

    [Step]
    public readonly struct EmitImageSummariesStep : IWfStep<EmitImageSummariesStep>
    {
        public static WfStepId StepId
            => Flow.step<EmitImageSummariesStep>();
    }

    [Step]
    public readonly struct EmitResBytesStep : IWfStep<EmitResBytesStep>
    {
        public const string StepName = nameof(EmitResBytes);

        public static WfStepId StepId
            => Flow.step<EmitResBytesStep>();

    }

    [Step]
    public readonly struct ParseAsmFilesStep : IWfStep<ParseAsmFilesStep>
    {
        public static WfStepId StepId
            => Flow.step<ParseAsmFilesStep>();
    }


    [Step]
    public readonly struct EmitImageDataStep : IWfStep<EmitImageDataStep>
    {
        public static WfStepId StepId
            => step<EmitImageDataStep>();
    }


    [Step]
    public readonly struct EmitStepListStep : IWfStep<EmitStepListStep>
    {
        public static WfStepId StepId
            => step<EmitStepListStep>();
    }
}