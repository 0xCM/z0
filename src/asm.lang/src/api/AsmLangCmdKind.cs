//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    [WfCmdKind]
    public enum AsmLangCmdKind : byte
    {
        None = 0,

        [Alias("show-all-syms")]
        ShowAllSymbols,

        [Alias("show-composites-syms")]
        ShowCompositeSymbols,

        [Alias("show-mode-syms")]
        ShowModeSymbols,

        [Alias("show-eflag-syms")]
        ShowEFlagSymbols,

        [Alias("show-monic-syms")]
        ShowMnemonicSymbols,

        [Alias("show-operator-syms")]
        ShowOperandSymbols,

        [Alias("show-reg-bits")]
        ShowRegBits,

        [Alias("show-rex-bits")]
        ShowRexBits,

    }
}