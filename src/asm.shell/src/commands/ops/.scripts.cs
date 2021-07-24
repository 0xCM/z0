//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".scripts")]
        public Outcome Scripts(CmdArgs args)
        {
            var tool = args.IsNonEmpty ? (ToolId)arg(args,0).Value : State.Tool();
            if(tool.IsEmpty)
                return (false, NoToolSelected.Format());

            var dir = State.Tools().Scripts(tool);
            var files = Pipe(dir.AllFiles.View);
            return true;
        }
    }
}