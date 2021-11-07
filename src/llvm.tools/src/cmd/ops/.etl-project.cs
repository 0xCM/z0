//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    partial class LlvmCmd
    {
        [CmdOp(".etl-projects")]
        Outcome RunProjectsEtl(CmdArgs args)
        {
            ProjectEtl.Collect();
            return true;
        }
    }
}