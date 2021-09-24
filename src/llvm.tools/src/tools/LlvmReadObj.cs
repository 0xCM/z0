//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    public sealed class LlvmReadObj : ToolService<LlvmReadObj>
    {
        public override ToolId Id
            => LlvmToolNames.llvm_readobj;
    }
}