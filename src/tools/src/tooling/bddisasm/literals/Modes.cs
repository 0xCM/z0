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
        public enum Modes : byte
        {
            [Symbol("r0")]
            ND_MOD_R0,

            [Symbol("r1")]
            ND_MOD_R1,

            [Symbol("r2")]
            ND_MOD_R2,

            [Symbol("r3")]
            ND_MOD_R3,

            [Symbol("real")]
            ND_MOD_REAL,

            [Symbol("v8086")]
            ND_MOD_V8086,

            [Symbol("prot")]
            ND_MOD_PROT,

            [Symbol("compat")]
            ND_MOD_COMPAT,

            [Symbol("long")]
            ND_MOD_LONG,

            [Symbol("smm")]
            ND_MOD_SMM,

            [Symbol("smm_off")]
            ND_MOD_SMM_OFF,

            [Symbol("sgx")]
            ND_MOD_SGX,

            [Symbol("sgx_off")]
            ND_MOD_SGX_OFF,

            [Symbol("tsx")]
            ND_MOD_TSX,

            [Symbol("tsx_off")]
            ND_MOD_TSX_OFF,

            [Symbol("vmxr")]
            ND_MOD_VMXR,

            [Symbol("vmxn")]
            ND_MOD_VMXN,

            [Symbol("vmxr_seam")]
            ND_MOD_VMXR_SEAM,

            [Symbol("vmxn_seam")]
            ND_MOD_VMXN_SEAM,

            [Symbol("vmx_off")]
            ND_MOD_VMX_OFF,
        }
    }
}