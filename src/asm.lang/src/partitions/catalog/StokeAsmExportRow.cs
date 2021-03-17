//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{

    [Record(TableId)]
    public struct StokeAsmExportRow : IRecord<StokeAsmExportRow>
    {
        public const string TableId = "stoke.export";

        public ushort Sequence;

        public AsmOpCodeExpr OpCode;

        public string Instruction;

        public bool Mode64;

        public string LegacyMode;

        public string EncodingKind;

        public string Properties;

        public string ImplicitRead;

        public string ImplicitWrite;

        public string ImplicitUndef;

        public string Protected;

        public string Cpuid;

        public string AttMnemonic;

        public string Description;
    }
}