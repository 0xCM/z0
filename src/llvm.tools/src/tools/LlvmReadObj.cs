//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;

    using static core;

    public sealed class LlvmReadObj : ToolService<LlvmReadObj>
    {
        public override ToolId Id
            => Toolspace.llvm_readobj;
    }
}