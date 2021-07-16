//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    partial class AsmCmdService
    {
        [CmdOp(".scripts")]
        public Outcome Scripts(CmdArgs args)
        {
            var tool = args.IsNonEmpty ? (ToolId)arg(args,0).Value : Tool();
            if(tool.IsEmpty)
                return (false, NoToolSelected.Format());

            var dir = ToolBase().Scripts(tool);
            var files = Pipe(dir.AllFiles.View);
            return true;
        }
    }
}