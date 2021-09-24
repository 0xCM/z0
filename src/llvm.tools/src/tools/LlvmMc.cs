//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    public sealed partial class LlvmMc : ToolService<LlvmMc>
    {
        public override ToolId Id
            => LlvmToolNames.llvm_mc;
    }
}