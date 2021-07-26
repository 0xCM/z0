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
            var records = NasmCatalog.ImportInstructions();
            return true;
        }

        [CmdOp(".list-nasm-inst")]
        Outcome ListNasmInstructions(CmdArgs args)
        {
            var records = NasmCatalog.LoadInstructionImports();
            var formatter = Tables.formatter<NasmInstruction>();
            iter(records, r => Write(formatter.Format(r)));
            return true;
        }
    }
}