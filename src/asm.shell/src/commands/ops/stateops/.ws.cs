//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".ws")]
        Outcome WsCmd(CmdArgs args)
        {
            if(args.Length == 0)
                Write(State.Workspace());
            else
                Write(State.Workspace(new Workspace(Wf.Env.DevWs + FS.folder(arg(args,0).Value))));
            return true;
        }
    }
}