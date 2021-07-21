//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".import-nasm-data")]
        Outcome EmitNasmInstructions(CmdArgs args)
        {
            var src = Workspace.DataSource("nasm-instructions", FS.Txt);
            var dst = TablePath<NasmInstruction>();
            Wf.NasmCatalog().EmitInstructions(src, dst);
            return true;
        }
    }
}