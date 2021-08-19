//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".sdm-opcode-strings")]
        public Outcome SdmOpCodeStrings(CmdArgs args)
            => GenSdmOpCodeStrings();
    }
}