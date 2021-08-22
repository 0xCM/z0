//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using Z0.llvm;

    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".llvm-data")]
        Outcome EmitLlvmTables(CmdArgs args)
        {
            var result = Outcome.Success;
            EmitSymKinds(Symbols.index<MC.Register>(), TableWs().LlvmTable(LlvmTableNames.regnames));
            TableEmit(LlvmOpCodes(), OpCodeSpec.RenderWidths, TableWs().LlvmTable<OpCodeSpec>());
            EmitLlvmMnemonics();
            ImportLists(LlvmDatasetNames.TblgenLists, "llvm");
            GenLlvmStringTables();
            return result;
        }

        void EmitLlvmMnemonics()
        {
            var mc = MC.calcs();
            var monics = mc.Monics().View;
            var buffer = text.buffer();
            iteri(monics, (i,d) => buffer.AppendLine(string.Format("{0,-8} | {1}", i,d)));
            var dst = TableWs().LlvmTable(LlvmTableNames.mnemonics);
            using var writer = dst.AsciWriter();
            writer.WriteLine(string.Format("{0,-8} | {1}", "Id", "Mnemonic"));
            writer.Write(buffer.Emit());
            Emitted(dst);
        }
    }
}