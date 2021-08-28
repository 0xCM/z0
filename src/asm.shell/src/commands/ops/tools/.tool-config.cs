//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".tool-config")]
        Outcome ConfigureTool(CmdArgs args)
        {
            var result = Outcome.Success;
            ToolId tool = arg(args,0).Value;
            var script = Ws.Tools().ConfigScript(tool);
            result = OmniScript.Run(script, out var _);
            var logpath = Ws.Tools().ConfigLog(tool);
            using var reader = logpath.AsciLineReader();
            while(reader.Next(out var line))
            {
                Write(line.Format());
            }

            return result;
        }
    }
}