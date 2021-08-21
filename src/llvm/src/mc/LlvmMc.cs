//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;

    public class LlvmMc : ToolService<LlvmMc>
    {
        public LlvmMc()
            : base(Toolspace.llvm_mc)
        {

        }

        public Outcome Parse(FS.FilePath src, out ReadOnlySpan<McAsmRow> dst)
        {
            dst = default;

            return true;
        }
    }
}