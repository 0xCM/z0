//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using static LlvmDatasetNames;

    partial class EtlWorkflow
    {
        public Outcome EmitTables()
        {
            var result = Outcome.Success;
            EmitLines(Sources.Instructions.View, LlvmPaths.LinedRecordPath(LlvmDatasetKind.Instructions), TextEncodingKind.Asci);
            EmitLines(Sources.Intrinsics.View, LlvmPaths.LinedRecordPath(LlvmDatasetKind.Intrinsics), TextEncodingKind.Asci);
            TableEmit(Defs(LlvmDatasetKind.Instructions, DefinesInstruction), DefRecord.RenderWidths, LlvmPaths.RecordIndex(X86Instructions));
            TableEmit(Classes(LlvmDatasetKind.Instructions), ClassRecord.RenderWidths, LlvmPaths.RecordIndex(X86Classes));
            TableEmit(Defs(LlvmDatasetKind.Intrinsics), DefRecord.RenderWidths, LlvmPaths.RecordIndex(LlvmIntrinsics));
            return result;
        }
    }
}