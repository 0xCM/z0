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

    [Step]
    public sealed class EmitAsmSymbols : WfHost<EmitAsmSymbols>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitAsmSymbolsStep(wf,this);
            step.Run();
        }
    }

    ref struct EmitAsmSymbolsStep
    {
        readonly IWfShell Wf;

        readonly WfHost Host;
        [MethodImpl(Inline)]
        public EmitAsmSymbolsStep(IWfShell wf, WfHost host)
        {
            Wf = wf;
            Host = host;
            Wf.Created(Host);
        }

        public void Run()
        {
            Wf.Running(Host);
            TryRun();
            Wf.Ran(Host);
        }

        void EmitMnemonics()
        {
            const string Pattern = "{0,-20} | {1,-20} | {2,-20} | {3}";
            var dst = Wf.AppData + FS.folder("symbols") + FS.file("mnemonics", FileExtensions.Csv);

            var symbols = AsmCodes.symbols();
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
           Wf.Disposed(Host);
        }
    }
}