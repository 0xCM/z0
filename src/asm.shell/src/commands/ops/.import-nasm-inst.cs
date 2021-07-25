//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".import-nasm-inst")]
        Outcome EmitNasmInstructions(CmdArgs args)
        {
            var src = SouceWs().Path("nasm-instructions", FS.Txt);
            var dst = TableWs().Table<NasmInstruction>(AsmTableScopes.Nasm);
            Wf.NasmCatalog().ImportInstructions(src, dst);
            return true;
        }

        [CmdOp(".list-nasm-inst")]
        Outcome ListNasmInstructions(CmdArgs args)
        {
            var src = TableWs().Table<NasmInstruction>(AsmTableScopes.Nasm);
            var records = Wf.NasmCatalog().LoadInstructionImports(src);
            var formatter = Tables.formatter<NasmInstruction>();
            iter(records, r => Write(formatter.Format(r)));
            return true;
        }
    }
}