//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;

    using records;

    partial class EtlWorkflow
    {
        ReadOnlySpan<DefRelations> ImportDefRelations(ReadOnlySpan<TextLine> src)
        {
            const string Marker = "def ";
            var collected = DistillRelations<DefRelations>(src,Marker);
            TableEmit(collected, DefRelations.RenderWidths, LlvmPaths.Table<DefRelations>());
            return collected;
        }
    }
}