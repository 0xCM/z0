//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Collections.Generic;

    using records;

    using Asm;

    public ref struct ProjectDatasets
    {
        public ReadOnlySpan<AsmSyntaxRow> AsmSyntaxRecords;
    }
}