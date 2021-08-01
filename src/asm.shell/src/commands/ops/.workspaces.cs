//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".workspaces", "Lists the avaliable workspaces")]
        Outcome Workspaces(CmdArgs args)
        {
            Write(WsNames.asm);
            Write(WsNames.control);
            Write(WsNames.gen);
            Write(WsNames.imports);
            Write(WsNames.lang);
            Write(WsNames.logs);
            Write(WsNames.projects);
            Write(WsNames.queries);
            Write(WsNames.sources);
            Write(WsNames.tables);
            Write(WsNames.tools);
            Write(WsNames.output);
            return true;
        }
    }
}