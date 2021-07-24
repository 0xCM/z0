//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Llvm
    {
        [Tool]
        public readonly struct Lli : ITool<Lli>
        {
            public ToolId Id => Toolspace.llvm_lli;
        }

        [Cmd]
        public struct LliCmd : IToolCmd<LliCmd,Lli>
        {

        }
    }
}