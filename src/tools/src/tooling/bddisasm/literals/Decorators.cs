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
        public enum Decorators : byte
        {
            [Symbol("{K}")]
            ND_OPD_MASK,

            [Symbol("{z}")]
            ND_OPD_Z,

            [Symbol("{sae}")]
            ND_OPD_SAE,

            [Symbol("{er}")]
            ND_OPD_ER,

            [Symbol("|B32")]
            ND_OPD_B32,

            [Symbol("|B64")]
            ND_OPD_B64,
        }
    }
}