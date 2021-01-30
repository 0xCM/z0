//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    [Record(TableId)]
    public struct StokeAsmImportRow : IRecord<StokeAsmImportRow>
    {
        public const string TableId = "stoke-asmcat";

        public string OpCode;

        public string Instruction;

        public string EncodingKind;

        public string Properties;

        public string ImplicitRead;

        public string ImplicitWrite;

        public string ImplicitUndef;

        public string Useful;

        public string Protected;

        public string Mode64;

        public string LegacyMode;

        public string Cpuid;

        public string AttMnemonic;

        public string Preferred;

        public string Description;
    }
}