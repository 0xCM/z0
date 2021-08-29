//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".mc-disasm")]
        Outcome HexDecode(CmdArgs args)
            => HexDecode(arg(args,0).Value);

    }
}