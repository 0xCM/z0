//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    partial class AsmCmdService
    {
        [CmdOp(".samples")]
        Outcome ToolSamples(CmdArgs args)
            => RunTool(args, ToolSamples);

        Outcome ToolSamples(ToolId tool, CmdArgs args)
        {
            var dir = ToolBase().Scripts(tool);
            var files = Pipe(dir.AllFiles.View);
            return true;
        }
    }
}