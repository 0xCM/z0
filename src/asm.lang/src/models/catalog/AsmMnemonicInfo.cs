//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    [Record(TableId)]
    public struct AsmMnemonicInfo : IRecord<AsmMnemonicInfo>
    {
        public const string TableId = "asm.mnemonic-info";

        public AsmMnemonic Mnemonic;

        public TextBlock Description;

        public AsmMnemonicInfo(AsmMnemonic monic, TextBlock description)
        {
            Mnemonic = monic;
            Description = description;
        }
    }
}