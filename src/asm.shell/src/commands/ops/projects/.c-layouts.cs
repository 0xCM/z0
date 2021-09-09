//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static ProjectScriptNames;
    using static WsAtoms;

    partial class AsmCmdService
    {
        [CmdOp(".c-layouts")]
        Outcome CLayoutDump(CmdArgs args)
            => RunProjectScript(args, DumpLayouts, c);
    }
}