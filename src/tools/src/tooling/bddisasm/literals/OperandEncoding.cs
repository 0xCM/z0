//-----------------------------------------------------------------------------
// Copyright   : 2020 Bitdefender
// License     : Apache-2.0
// Source      : disasmlib.py
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    partial class BdDisasm
    {
        public enum OperandEncoding : byte
        {
            [Symbol("D", "Immediate, encoded directly in the instruction bytes")]
            A,

            [Symbol("B", "VEX/EVEX.vvvv encoded general purpose register")]
            B,

            [Symbol("R", "Modrm.reg encoded control register")]
            C,

            [Symbol("R", "Modrm.reg encoded debug register")]
            D,

            [Symbol("M", "Modrm.rm encoded general purpose register or memory")]
            E,

            [Symbol("R", "Modrm.reg encoded general purpose register")]
            G,

            [Symbol("V", "VEX/EVEX.vvvv encoded vector register")]
            H,

            [Symbol("I", "Immediate, encoded directly in the instruction bytes")]
            I,

            [Symbol("D", "Relative offset, encoded directly in the instruction bytes")]
            J,

            [Symbol("L", "Register encoded in an immediate")]
            L,

            [Symbol("M", "Modrm.rm encoded memory")]
            M,

            [Symbol("M","Modrm.rm encoded MMX register")]
            N,

            [Symbol("D","Absolute memory encoded directly in the instruction")]
            O,

            [Symbol("R","Modrm.reg encoded MMX register")]
            P,

            [Symbol("M","Modrm.rm encoded MMX register or memory")]
            Q,

            [Symbol("N","Modrm.rm encoded general purpose register")]
            R,

            [Symbol("R","Modrm.reg encoded segment register")]
            S,

            [Symbol("R"," Modrm.reg encoded test register")]
            T,

            [Symbol("M","Modrm.rm encoded vector register")]
            U,

            [Symbol("R","Modrm.reg encoded vector register")]
            V,

            [Symbol("M","Modrm.rm encoded vector register or memory")]
            W,

            [Symbol("O","General purpose register encoded in opcode low 3 bit")]
            Z,

            [Symbol("R","Modrm.reg encoded bound register")]
            rB,

            [Symbol("M","Modrm.rm encoded bound register or memory")]
            mB,

            [Symbol("R","Modrm.reg encoded mask register")]
            rK,

            [Symbol("V","VEX/EVEX.vvvv encoded mask register")]
            vK,

            [Symbol("M","Modrm.rm encoded mask register or memory")]
            mK,

            [Symbol("A","EVEX.aaa encoded mask register")]
            aK,

            [Symbol("R","Modrm.reg encoded memory")]
            mR,

            [Symbol("M","Modrm.rm encoded memory (always)")]
            mM,

            [Symbol("1","Constant 1")]
            One,

            [Symbol("CL","CL register")]
            CL,

            [Symbol("M","Modrm.rm encoded FPU register")]
            STi
        }
    }
}