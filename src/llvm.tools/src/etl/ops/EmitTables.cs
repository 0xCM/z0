//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;

    partial class EtlWorkflow
    {
        public Outcome EmitTables(ReadOnlySpan<TextLine> src)
        {
            var result = Outcome.Success;
            EmitLines(src, Ws.Project("llvm.data").Tables() + FS.file("x86.records.lined", FS.Txt), TextEncodingKind.Asci);
            // EmitLines(Sources.Intrinsics.View, LlvmPaths.LinedRecordPath(LlvmDatasetKind.Intrinsics), TextEncodingKind.Asci);
            // TableEmit(Defs(LlvmDatasetKind.Instructions, DefinesInstruction), DefRecord.RenderWidths, LlvmPaths.RecordIndex(X86Instructions));
            // TableEmit(Classes(LlvmDatasetKind.Instructions), ClassRecord.RenderWidths, LlvmPaths.RecordIndex(X86Classes));
            // TableEmit(Defs(LlvmDatasetKind.Intrinsics), DefRecord.RenderWidths, LlvmPaths.RecordIndex(LlvmIntrinsics));
            return result;
        }
    }
}