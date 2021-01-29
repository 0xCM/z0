//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [Record(TableId)]
    public struct StokeOpCodeRow : IRecord<StokeOpCodeRow>
    {
        public const string TableId = "stoke";

        public const string SourceHeader = "Opcode	Instruction	Op/En	Properties	Implicit Read	Implicit Write	Implicit Undef	Useful	Protected	64-bit Mode	Compat/32-bit-Legacy Mode	CPUID Feature Flags	AT&T Mnemonic	Preferred 	Description";

        public uint SourceLine;

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