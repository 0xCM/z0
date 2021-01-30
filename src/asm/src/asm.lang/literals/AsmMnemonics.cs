//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static AsmExpr;

    public readonly struct AsmMnemonics
    {
        public static AsmMnemonicExpr cmp => nameof(cmp);

        public static AsmMnemonicExpr movzx => nameof(movzx);

        public static AsmMnemonicExpr push => nameof(push);
    }
}
