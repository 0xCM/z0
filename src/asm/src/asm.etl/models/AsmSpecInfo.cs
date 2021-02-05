//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    [Record(TableId)]
    public struct AsmSpecInfo : IRecord<AsmSpecInfo>
    {
        public const string TableId = "asm.specs";

        public asci32 Mnemonic;

        public asci32 OpCode;

        public asci64 Sig;

        public TextBlock Description;
    }
}