//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".import-asm")]
        Outcome ImportAsm(CmdArgs args)
            => ImportAsm();

        // .project ll
        // .outfiles dumps/*.asm
        // .import-asm
    }
}