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
        public enum OpFlags : byte
        {
            [Symbol("OPDEF")]
            ND_OPF_DEFAULT,

            [Symbol("OPSEXO1")]
            ND_OPF_SEX_OP1,

            [Symbol("OPSEXDW")]
            ND_OPF_SEX_DWS,
        }
    }
}