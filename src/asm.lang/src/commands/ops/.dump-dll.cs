//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".dump-dll")]
        Outcome DumpDll(CmdArgs args)
        {
            return DumpModules(args, FileModuleKind.Dll);
        }
    }
}