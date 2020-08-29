//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Linq;

    using static Konst;
    using static z;

    using static EmitAsmSymbolsStep;

    [Step(typeof(EmitAsmSymbols), StepName)]
    public readonly struct EmitAsmSymbolsStep : IWfStep<EmitAsmSymbolsStep>
    {
        public const string StepName = nameof(EmitAsmSymbols);

        public static WfStepId StepId => AB.step<EmitAsmSymbolsStep>();
    }

    public ref struct EmitAsmSymbols
    {
        readonly IWfContext Wf;

        [MethodImpl(Inline)]
        public EmitAsmSymbols(IWfContext wf)
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
            var dst = Wf.AppDataRoot + FolderName.Define("symbols") + FileName.Define("mnemonics", FileExtensions.Csv);

            var symbols = asm.symbols();
            var src = symbols.Mnemonics.View;
            var count = src.Length;
            var fields = Enums.literals<SymbolFieldKind>();
            var symType = typeof(Asm.Mnemonic);
            var cellType = typeof(ushort);
            var header = text.format(Pattern, SymbolFieldKind.SymbolValue, SymbolFieldKind.SymbolType, SymbolFieldKind.CellValue, SymbolFieldKind.CellType);
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
           Wf.Finished(StepId);
        }
    }
}