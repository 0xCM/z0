//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".nasm-inst-list")]
        Outcome ListNasmInstructions(CmdArgs args)
        {
            var records = NasmCatalog.LoadInstructionImports();
            var formatter = Tables.formatter<NasmInstruction>();
            iter(records, r => Write(formatter.Format(r)));
            return true;
        }
    }
}