//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static MnemonicKind;
    using static AsmSymTypes;
    using static zfunc;

    partial class asm
    {

        [AsmInstr(VZEROUPPER)]
        public static AsmInstrExpr vzeroupper()
            => expr(VZEROUPPER);


    }

}