//-----------------------------------------------------------------------------
// Copyright   : 2020 Bitdefender
// License     : Apache-2.0
// Source      : generate_tables.py
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    partial class BdDisasm
    {
        [SymbolSource]
        public enum Flags : byte
        {
            [Symbol("MODRM")]
            ND_FLAG_MODRM,

            [Symbol("I64")]
            ND_FLAG_I64,

            [Symbol("F64")]
            ND_FLAG_F64,

            [Symbol("D64")]
            ND_FLAG_D64,

            [Symbol("O64")]
            ND_FLAG_O64,

            [Symbol("SSECONDB")]
            ND_FLAG_SSE_CONDB,

            [Symbol("COND")]
            ND_FLAG_COND,

            [Symbol("VSIB")]
            ND_FLAG_VSIB,

            [Symbol("MIB")]
            ND_FLAG_MIB,

            [Symbol("LIG")]
            ND_FLAG_LIG,

            [Symbol("WIG")]
            ND_FLAG_WIG,

            [Symbol("3DNOW")]
            ND_FLAG_3DNOW,

            [Symbol("MMASK")]
            ND_FLAG_MMASK,

            [Symbol("NOMZ")]
            ND_FLAG_NOMZ,

            [Symbol("LOCKSP")]
            ND_FLAG_LOCK_SPECIAL,

            [Symbol("NOL0")]
            ND_FLAG_NOL0,

            [Symbol("NOA16")]
            ND_FLAG_NOA16,

            [Symbol("NO66")]
            ND_FLAG_NO66,

            [Symbol("NORIPREL")]
            ND_FLAG_NO_RIP_REL,

            [Symbol("VECT")]
            ND_FLAG_VECTOR,

            [Symbol("S66")]
            ND_FLAG_S66,

            [Symbol("BITBASE")]
            ND_FLAG_BITBASE,

            [Symbol("AG")]
            ND_FLAG_AG,

            [Symbol("SHS")]
            ND_FLAG_SHS,

            [Symbol("MFR")]
            ND_FLAG_MFR,

            [Symbol("CETT")]
            ND_FLAG_CETT,

            [Symbol("SERIAL")]
            ND_FLAG_SERIAL,

            [Symbol("SIBMEM")]
            ND_FLAG_SIBMEM,

            [Symbol("I67")]
            ND_FLAG_I67,

            [Symbol("IER")]
            ND_FLAG_IER,
        }
    }
}