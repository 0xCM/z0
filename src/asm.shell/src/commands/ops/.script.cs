//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Root;
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".script")]
        public Outcome Script(CmdArgs args)
        {
            var tool = args.IsNonEmpty ? (ToolId)arg(args,0).Value : State.Tool();
            var tools = State.ToolBase();
            if(tool.IsEmpty)
                return (false, NoToolSelected.Format());

            var script = tools.Script(tool, arg(args,1).Value);
            if(!script.Exists)
                return (false, FS.missing(script));

            return RunScript(script, out var _);
        }


        Outcome RunScript(FS.FilePath src, out ReadOnlySpan<TextLine> response)
        {
            var result = Outcome.Success;

            void OnError(Exception e)
            {
                result = e;
            }

            var cmd = Cmd.cmdline(src.Format(PathSeparator.BS));
            response = ScriptRunner.RunCmd(cmd, OnError);
            return result;
        }
    }
}