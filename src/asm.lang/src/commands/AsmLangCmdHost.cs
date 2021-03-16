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

        [Action(K.ShowRegisterCodes)]
        void ShowRegisterCodes()
        {
            const string FormatPattern = "{0,-8} | {1,-10} | {2,-5} | {3,-10} | {4}";

            using var log = OpenShowLog("register-codes");
            var registers = AsmRegs.list();
            foreach(var reg in registers)
                Show(string.Format(FormatPattern, reg.Class, reg.Kind, reg.Width, (uint5)(byte)reg.Code, (Hex5)(byte)reg.Code), log);
        }

        [Action(K.ShowModeSymbols)]
        void ShowModeSymbols()
            => root.use(OpenShowLog("sigops.modes"), log => root.iter(SigSymbols.Modes.Tokens, token => Show(token, log)));

        [Action(K.ShowCompositeSymbols)]
        void ShowCompositeSymbols()
            => root.use(OpenShowLog("sigops.composites"), log => root.iter(SigSymbols.Composites.Tokens, token => Show(token, log)));

        [Action(K.ShowEFlagSymbols)]
        void ShowEFlagSymbols()
            => root.use(OpenShowLog("sigops.flags"), log => root.iter(SigSymbols.Flags.Tokens, token => Show(token, log)));

        [Action(K.ShowMnemonicSymbols)]
        void ShowMnemonicSymbols()
            => root.use(OpenShowLog("sigops.mnemonics"), log => root.iter(SigSymbols.Mnemonics.Tokens, token => Show(token, log)));

        [Action(K.ShowOperandSymbols)]
        void ShowOperandSymbols()
            => root.use(OpenShowLog("sigops.operands"), log => root.iter(SigSymbols.SigOps.Tokens, token => Show(token, log)));

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