//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".toolbase")]
        Outcome SelectToolbase(CmdArgs args)
        {
            ToolBase(arg(args,0).Value, FS.dir(arg(args,1).Value));
            return true;
        }
    }
}