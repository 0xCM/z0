//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    partial class LlvmCmd
    {
        [CmdOp(".collect")]
        Outcome Collect(CmdArgs args)
        {
            LlvmEtl.ProjectCollect();
            return true;
        }
    }
}