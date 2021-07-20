//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".dump-obj")]
        Outcome DumpObj(CmdArgs args)
        {
            return DumpModules(FileModuleKind.Obj);
        }
    }
}