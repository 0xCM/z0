//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    partial class LlvmCmd
    {
        [CmdOp(".etl")]
        Outcome RunEtl(CmdArgs args)
        {
            var data = LlvmEtl.RunEtl();
            return true;
        }
    }
}