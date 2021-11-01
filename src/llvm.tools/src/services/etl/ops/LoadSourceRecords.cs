//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;

    partial class LlvmEtlServices
    {
        public ReadOnlySpan<TextLine> LoadSourceRecords(string id)
        {
            using var reader = LlvmPaths.DataSourcePath(id).Utf8LineReader();
            return reader.ReadAll();
        }
    }
}