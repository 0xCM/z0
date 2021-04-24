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

    public sealed class AsmLangCmdHost : AppCmdHost<AsmLangCmdHost,K>
    {
        protected override void OnInit()
        {
        }

        [Action(K.ShowRegBits)]
        void ShowRegBits()
        {
            const string FormatPattern = "{0,-8} | {1,-10} | {2,-5} | {3,-10} | {4}";

            var query = AsmRegs.query();
            var classes = AsmRegs.classes();

            using var log = ShowLog("register-bits", FS.Log);

            foreach(var k in classes)
            {
                var registers = query.Where(k);
                foreach(var r in registers)
                    log.Show(r);
            }
        }

        // [Action(K.ShowModeSymbols)]
        // void ShowModeSymbols()
        //     => root.use(OpenShowLog("sigops.modes"), log => root.iter(SigSymbols.Modes.Storage, symbol => Show(symbol, log)));


        // [Action(K.ShowEFlagSymbols)]
        // void ShowEFlagSymbols()
        //     => root.use(OpenShowLog("sigops.flags"), log => root.iter(SigSymbols.Flags.Storage, symbol => Show(symbol, log)));

        // [Action(K.ShowMnemonicSymbols)]
        // void ShowMnemonicSymbols()
        //     => root.use(OpenShowLog("sigops.mnemonics"), log => root.iter(SigSymbols.Mnemonics.Storage, symbol => Show(symbol, log)));

        [Action(K.ShowRexBits)]
        void ShowRexBits()
        {
            var bits = AsmEncoder.RexPrefixBits();
            using var log = OpenShowLog("rexbits");
            var count = bits.Length;
            for(var i=0; i<count; i++)
                Show(AsmEncoder.describe(skip(bits,i)), log);
        }
    }
}