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
        public enum AccessMap : byte
        {
            [Symbol("R")]
            ND_OPA_R,

            [Symbol("W")]
            ND_OPA_W,

            [Symbol("CR")]
            ND_OPA_CR,

            [Symbol("CW")]
            ND_OPA_CW,

            [Symbol("RW")]
            ND_OPA_RW,

            [Symbol("RCW")]
            ND_OPA_RCW,

            [Symbol("CRW")]
            ND_OPA_CRW,

            [Symbol("CRCW")]
            ND_OPA_CRCW,

            [Symbol("P")]
            ND_OPA_P,

            [Symbol("N")]
            ND_OPA_N,
        }
    }
}