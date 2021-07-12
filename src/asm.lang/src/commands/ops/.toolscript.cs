//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    partial class AsmCmdService
    {
        [CmdOp(".toolscript")]
        public Outcome ToolScript(CmdArgs args)
        {
            var tool = args.IsNonEmpty ? (ToolId)arg(args,0).Value : Tool();
            var tools = ToolBase();
            if(tool.IsEmpty)
                return (false, "A tool has not been selected");

            var script = tools.Script(tool, arg(args,1).Value);
            if(!script.Exists)
                return (false, FS.missing(script));

            var result = Outcome.Success;
            void OnError(Exception e)
            {
                result = e;
            }

            var cmd = Cmd.cmdline(script.Format(PathSeparator.BS));
            var response = ScriptRunner.RunCmd(cmd, OnError);

            return result;
        }
    }
}