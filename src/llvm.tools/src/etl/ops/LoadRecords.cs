//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;

    partial class EtlWorkflow
    {
        public ReadOnlySpan<TextLine> LoadRecords()
        {
            var src = LlvmData.OutDir() + FS.file("X86.records", FS.Txt);
            using var reader = src.Utf8LineReader();
            return reader.ReadAll();
        }
    }
}