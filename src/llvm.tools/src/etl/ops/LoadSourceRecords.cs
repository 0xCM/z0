//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;

    partial class EtlWorkflow
    {
        public ReadOnlySpan<TextLine> LoadSourceRecords()
        {
            using var reader = LlvmPaths.TableGenSource("X86.records").Utf8LineReader();
            return reader.ReadAll();
        }
    }
}