//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{

    partial struct Llvm
    {
        [Tool]
        public readonly struct Lli : ITool<Lli>
        {
            public Name ToolName => "lli";
        }

        [Cmd]
        public struct LliCmd : IToolCmd<LliCmd,Lli>
        {

        }
    }
}