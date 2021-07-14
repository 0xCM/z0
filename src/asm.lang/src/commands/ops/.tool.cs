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
                ToolId tool = arg(args,0).Value;
                var dir = ToolBase().Home(tool);
                Outcome outcome = dir.Exists;
                if(outcome)
                {
                    Tool(tool);
                    Write(string.Format("{0} selected", tool));
                }
                else
                    outcome = (false, $"The tool {tool} is not defined in the current toolbase");
                return outcome;
            }
    }
}