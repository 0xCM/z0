//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;
    using static z;

    public struct EmitAsmSymbolsCmd : ICmdSpec<EmitAsmSymbolsCmd>
    {

    }

    public sealed class EmitAsmSymbols : CmdHost<EmitAsmSymbols, EmitAsmSymbolsCmd>
    {
        public static EmitAsmSymbolsCmd specify(IWfShell wf)
            => new EmitAsmSymbolsCmd();

        public static new CmdResult run(IWfShell wf, in EmitAsmSymbolsCmd spec)
        {
            const string RenderPattern = "{0,-20} | {1,-20} | {2,-20} | {3}";
            const string TableId = "asm.mnemonics";

            var target = wf.Db().RefDataPath(TableId);
            var symbols = AsmOpCodes.symbols();
            var src = symbols.Mnemonics.View;
            var count = src.Length;
            var fields = Enums.literals<SymbolAspectKind>();
            var symType = typeof(Asm.Mnemonic);
            var cellType = typeof(ushort);
            var header = text.format(RenderPattern, SymbolAspectKind.SymbolValue, SymbolAspectKind.SymbolType, SymbolAspectKind.CellValue, SymbolAspectKind.CellType);
            using var writer = target.Writer();
            writer.WriteLine(header);
            for(var i=0u; i<count; i++)
            {
                ref readonly var symbol = ref skip(src,i);
                var rendered = text.format(RenderPattern, symbol.Value, symType.Name, symbol.Cell, cellType.Name);
                writer.WriteLine(rendered);
            }
            return Win();
        }

        protected override CmdResult Execute(IWfShell wf, in EmitAsmSymbolsCmd spec)
            => run(wf,spec);
    }
}