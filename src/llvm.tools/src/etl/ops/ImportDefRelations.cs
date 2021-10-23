//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;

    partial class EtlWorkflow
    {
        ReadOnlySpan<DefRelations> ImportDefRelations(ReadOnlySpan<TextLine> src)
        {
            const string Marker = "def ";
            var collected = DistillRelations<DefRelations>(src,Marker);
            TableEmit(collected, DefRelations.RenderWidths, LlvmPaths.ImportTable<DefRelations>());
            return collected;
        }
    }
}