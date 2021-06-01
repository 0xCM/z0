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
        public enum Decorator : byte
        {
            [Symbol("MASK")]
            ND_DECO_MASK,

            [Symbol("BROADCAST")]
            ND_DECO_BROADCAST,

            [Symbol("ZERO")]
            ND_DECO_ZERO,

            [Symbol("SAE")]
            ND_DECO_SAE,

            [Symbol("ER")]
            ND_DECO_ER,
        }
    }
}