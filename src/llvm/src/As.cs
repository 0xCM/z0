//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Llvm
    {
        [Tool]
        public readonly struct As : ITool<As>
        {
            public ToolId Id => Toolspace.llvm_as;
        }
    }
}