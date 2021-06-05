//-----------------------------------------------------------------------------
// Copyright   : 2020 Bitdefender
// License     : Apache-2.0
// Source      : disasmlib.py
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    partial class BdDisasm
    {
        [SymbolSource]
        public enum Attributes : byte
        {
            [Symbol("modrm","Mod r/m is present")]
            MODRM,

            [Symbol("ii64","Instruction invalid in 64 bit mode")]
            II64,

            [Symbol("f64","Operand size forced to 64 bit")]
            F64,

            [Symbol("d64","Operand size defaults to 64 bit")]
            D64,

            [Symbol("o64","Instruction valid only in 64 bit mode")]
            O64,

            [Symbol("","Instruction has condition byte")]
            SSECONDB,

            [Symbol("cond","Instruction has predicated encoded in lower 4 bit of the opcode")]
            COND,

            [Symbol("vsib","Instruction uses VSIB addressing")]
            VSIB,

            [Symbol("mib","Instruction uses MIB addressing")]
            MIB,

            [Symbol("LIG","*vex.L is ignored")]
            LIG,

            [Symbol("WIG","*vex.W is ignored")]
            WIG,

            [Symbol("3DNOW","Instruction uses 3dnow encoding")]
            _3DNOW,

            [Symbol("","Instruction must have mask specified (mask cannot be k0)")]
            MMASK,

            [Symbol("","Zeroing not allowed with memory addressing")]
            NOMZ,

            [Symbol("","Special lock - MOV CR on amd can use LOCK to access CR8 in 32 bit mode")]
            LOCKSP,

            [Symbol("","Vector length 128 not supported")]
            NOL0,

            [Symbol("","16 bit addressing not supported")]
            NOA16,

            [Symbol("","0x66 prefix causes //UD")]
            NO66,

            [Symbol("","RIP relative addressing not supported")]
            NORIPREL,

            [Symbol("","Vector instruction")]
            VECT,

            [Symbol("","0x66 prefix changes length even if it is in special map (66, f2, f3)")]
            S66,

            [Symbol("","Instruction uses bitbase addressing")]
            BITBASE,

            [Symbol("","Instruction uses address generation, no memory access")]
            AG,

            [Symbol("","Instruction accesses the shadow stack")]
            SHS,

            [Symbol("","The Mod inside Mod R/M is forced to register. No SIB/disp present")]
            MFR,

            [Symbol("","Instruction is CET tracked")]
            CETT,

            [Symbol("","Operand 1 is default (implicit)")]
            OP1DEF,

            [Symbol("","Operand 2 is default (implicit)")]
            OP2DEF,

            [Symbol("","Operand 2 is sign-extended to the size of the first operand")]
            OP2SEXO1,

            [Symbol("","Operand 3 is sign-extended to the size of the first operand")]
            OP3SEXO1,

            [Symbol("","Operand 1 is sign-extended to the size of the default word")]
            OP1SEXDW,

            [Symbol("","Prefix")]
            PREFIX,

            [Symbol("","Instruction is serializing")]
            SERIAL,

            [Symbol("","Instruction uses sibmem addressing (AMX instructions)")]
            SIBMEM,

            [Symbol("","Ignore the address size override (0x67) prefix in 64 bit mode")]
            I67,

            [Symbol("","Ignore embedded rounding for the instruction")]
            IER,
        }
    }
}