//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Llvm
    {
        [Tool]
        public readonly struct Llc : ITool<Llc>
        {
            public ToolId Id => Toolspace.llc;
        }

        [Cmd]
        public struct LlcCmd : IToolCmd<LlcCmd,Lli>
        {



        }
    }
}