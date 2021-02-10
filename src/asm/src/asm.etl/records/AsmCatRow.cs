//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static AsmExpr;

    [Record(TableId)]
    public struct AsmCatRow : IRecord<AsmCatRow>
    {
        public const string TableId = "asmcat";

        public uint Sequence;

        public AsmMnemonicCode Mnemonic;

        public OpCode OpCode;

        public Signature Instruction;

        public Name EncodingKind;

        public Index<Name> Properties;

        public Index<EFlagKind> FlagsRead;

        public Index<EFlagKind> FlagsWritten;

        public Name ModeIndicator;

        public Name LegacyIndicator;

        public Name Cpuid;

        public Name AttMnemonic;

        public TextBlock Description;
    }
}

