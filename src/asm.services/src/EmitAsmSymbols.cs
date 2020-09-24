//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using static EmitAsmSymbolsStep;

    [Step]
    public struct EmitAsmSymbolsStep : IWfStep<EmitAsmSymbolsStep>
    {
        public static WfStepId StepId
            => type<EmitAsmSymbolsStep>();
    }

    public ref struct EmitAsmSymbols
    {
        readonly IWfShell Wf;

        [MethodImpl(Inline)]
        public EmitAsmSymbols(IWfShell wf)
        {
            Wf = wf;
            Wf.Created(StepId);
        }

        public void Run()
        {
            Wf.Running(StepId);
            TryRun();
            Wf.Ran(StepId);
        }

        void EmitMnemonics()
        {
            const string Pattern = "{0,-20} | {1,-20} | {2,-20} | {3}";
            var dst = Wf.AppDataRoot + FolderName.Define("symbols") + FileName.define("mnemonics", FileExtensions.Csv);

            var symbols = asm.symbols();
            var src = symbols.Mnemonics.View;
            var count = src.Length;
            var fields = Enums.literals<SymbolAspectKind>();
            var symType = typeof(Asm.Mnemonic);
            var cellType = typeof(ushort);
            var header = text.format(Pattern, SymbolAspectKind.SymbolValue, SymbolAspectKind.SymbolType, SymbolAspectKind.CellValue, SymbolAspectKind.CellType);
            using var writer = dst.Writer();
            writer.WriteLine(header);
            for(var i=0u; i<count; i++)
            {
                ref readonly var symbol = ref skip(src,i);
                var rendered = text.format(Pattern, symbol.Value, symType.Name, symbol.Cell, cellType.Name);
                writer.WriteLine(rendered);
            }
        }

        void Execute()
        {
            EmitMnemonics();
        }

        void TryRun()
        {
            try
            {
                Execute();
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
        }

        public void Dispose()
        {
           Wf.Disposed(StepId);
        }
    }
}