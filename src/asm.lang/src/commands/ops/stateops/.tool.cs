//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".tool")]
        Outcome SelectTool(CmdArgs args)
        {
            var outcome = Outcome.Success;
            if(args.Length == 0)
            {
                Write(Tool());
            }
            else
            {
                ToolId id = arg(args,0).Value;
                var dir = ToolBase().Home(id);
                outcome = dir.Exists;
                if(outcome)
                {
                    Tool(id);
                    Write(string.Format("{0} selected", id));
                }
                else
                    outcome = (false, UndefinedTool.Format(id));
            }

            return outcome;
        }
    }
}