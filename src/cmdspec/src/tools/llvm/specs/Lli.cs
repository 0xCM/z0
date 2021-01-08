//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{

    partial struct Llvm
    {
        [Tool]
        public readonly struct Lli : ITool<Lli>
        {
            public string ToolName => "lli";
        }

        [Cmd]
        public struct LliCmd : IToolCmd<LliCmd,Lli>
        {

        }
    }
}