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
        public enum Prefix : byte
        {
            [Symbol("REP")]
            ND_PREF_REP,

            [Symbol("REPC")]
            ND_PREF_REPC,

            [Symbol("HLE")]
            ND_PREF_HLE,

            [Symbol("BND")]
            ND_PREF_BND,

            [Symbol("LOCK")]
            ND_PREF_LOCK,

            [Symbol("BH")]
            ND_PREF_BHINT,

            [Symbol("XACQUIRE")]
            ND_PREF_XACQUIRE,

            [Symbol("XRELEASE")]
            ND_PREF_XRELEASE,

            [Symbol("HLEWOL")]
            ND_PREF_HLE_WO_LOCK,

            [Symbol("DNT")]
            ND_PREF_DNT,
        }
    }
}