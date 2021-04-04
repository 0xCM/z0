//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static memory;

    using K = AsmLangCmdKind;

    public sealed class AsmLangCmdHost : WfCmdHost<AsmLangCmdHost,K>
    {
        Lazy<AsmSigSymbols> _SigSymbols;

        AsmSigSymbols SigSymbols
        {
            get => _SigSymbols.Value;
        }

        protected override void OnInit()
        {
            _SigSymbols = root.lazy(AsmSigSymbols.load);
        }

        [Action(K.ShowAllSymbols)]
        void ShowSigSymbols()
        {
            ShowMnemonicSymbols();
            ShowOperandSymbols();
            ShowEFlagSymbols();
            ShowCompositeSymbols();
            ShowModeSymbols();
        }

        [Action(K.ShowRegBits)]
        void ShowRegBits()
        {
            const string FormatPattern = "{0,-8} | {1,-10} | {2,-5} | {3,-10} | {4}";

            var query = AsmRegs.query();
            var classes = AsmRegs.classes();

            using var log = ShowLog("register-bits", FS.Extensions.Log);

            foreach(var k in classes)
            {
                var registers = query.Where(k);
                foreach(var r in registers)
                    log.Show(r);
            }
        }

        [Action(K.ShowModeSymbols)]
        void ShowModeSymbols()
            => root.use(OpenShowLog("sigops.modes"), log => root.iter(SigSymbols.Modes.Storage, symbol => Show(symbol, log)));

        [Action(K.ShowCompositeSymbols)]
        void ShowCompositeSymbols()
            => root.use(OpenShowLog("sigops.composites"), log => root.iter(SigSymbols.Composites.Storage, symbol => Show(symbol, log)));

        [Action(K.ShowEFlagSymbols)]
        void ShowEFlagSymbols()
            => root.use(OpenShowLog("sigops.flags"), log => root.iter(SigSymbols.Flags.Storage, symbol => Show(symbol, log)));

        [Action(K.ShowMnemonicSymbols)]
        void ShowMnemonicSymbols()
            => root.use(OpenShowLog("sigops.mnemonics"), log => root.iter(SigSymbols.Mnemonics.Storage, symbol => Show(symbol, log)));

        [Action(K.ShowOperandSymbols)]
        void ShowOperandSymbols()
            => root.use(OpenShowLog("sigops.operands"), log => root.iter(SigSymbols.SigOps.Storage, symbol => Show(symbol, log)));

        [Action(K.ShowRexBits)]
        void ShowRexBits()
        {
            var bits = Rex.bits();
            using var log = OpenShowLog("rexbits");
            var count = bits.Length;
            for(var i=0; i<count; i++)
                Show(Rex.FormatRow(skip(bits,i)), log);
        }
    }
}