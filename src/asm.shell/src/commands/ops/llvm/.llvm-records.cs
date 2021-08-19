//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using Z0.llvm;

    using static Root;
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".llvm-records")]
        Outcome LlvmRecords(CmdArgs args)
        {
            var dst = new LlvmRecordSources();
            var svc = Wf.LlvmDatasets(DataSources);

            var result = svc.Load(LlvmDatasetKind.Instructions | LlvmDatasetKind.Details, ref dst);
            result.OnSuccess(path => Write(path.ToUri().Format(), dst.InstructionDetails.Count));

            result = svc.Load(LlvmDatasetKind.Instructions | LlvmDatasetKind.Summary, ref dst);
            result.OnSuccess(path => Write(path.ToUri().Format(), dst.InstructionSummary.Count));

            result = svc.Load(LlvmDatasetKind.Regs, ref dst);
            result.OnSuccess(path => Write(path.ToUri().Format(), dst.Regs.Count));

            result = svc.Load(LlvmDatasetKind.Intrinsics | LlvmDatasetKind.Details, ref dst);
            result.OnSuccess(path => Write(path.ToUri().Format(), dst.IntrinsicsDetails.Count));

            result = svc.Load(LlvmDatasetKind.Intrinsics | LlvmDatasetKind.Summary, ref dst);
            result.OnSuccess(path => Write(path.ToUri().Format(), dst.IntrinsicsSummary.Count));

            result = svc.Load(LlvmDatasetKind.ValueTypes | LlvmDatasetKind.Summary, ref dst);
            result.OnSuccess(path => Write(path.ToUri().Format(), dst.ValueTypesSummary.Count));

            result = svc.Load(LlvmDatasetKind.ValueTypes | LlvmDatasetKind.Details, ref dst);
            result.OnSuccess(path => Write(path.ToUri().Format(), dst.ValueTypesDetails.Count));

            Write(string.Format("Loaded {0} lines", dst.TotalLineCount()));

            return result;
        }
    }
}