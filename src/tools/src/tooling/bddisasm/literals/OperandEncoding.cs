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
            // 'D',   Immediate, encoded directly in the instruction bytes.
            A,

            // 'V',   VEX/EVEX.vvvv encoded general purpose register.
            B,

            // 'R',   Modrm.reg encoded control register.
            C,

            // 'R',   Modrm.reg encoded debug register.
            D,

            // 'M',   Modrm.rm encoded general purpose register or memory.
            E,

            // 'R',   Modrm.reg encoded general purpose register.
            G,

            // 'V',   VEX/EVEX.vvvv encoded vector register.
            H,

            // 'I',   Immediate, encoded directly in the instruction bytes.
            I,

            // 'D',   Relative offset, encoded directly in the instruction bytes.
            J,

            // 'L',   Register encoded in an immediate.
            L,

            // 'M',   Modrm.rm encoded memory.
            M,

            // 'M',   Modrm.rm encoded MMX register.
            N,

            // 'D',   Absolute memory encoded directly in the instruction.
            O,

            // 'R',   Modrm.reg encoded MMX register.
            P,

            // 'M',   Modrm.rm encoded MMX register or memory.
            Q,

            // 'M',   Modrm.rm encoded general purpose register.
            R,

            // 'R',   Modrm.reg encoded segment register.
            S,

            // 'R',   Modrm.reg encoded test register.
            T,

            // 'M',   Modrm.rm encoded vector register.
            U,

            // 'R',   Modrm.reg encoded vector register.
            V,

            // 'M',   Modrm.rm encoded vector register or memory.
            W,

            // 'O',   General purpose register encoded in opcode low 3 bit.
            Z,

            //'R',   Modrm.reg encoded bound register.
            rB,

            //'M',   Modrm.rm encoded bound register or memory.
            mB,

            //'R',   Modrm.reg encoded mask register.
            rK,

            //'V',   VEX/EVEX.vvvv encoded mask register.
            vK,

            //'M',   Modrm.rm encoded mask register or memory.
            mK,

            //'A',   EVEX.aaa encoded mask register.
            aK,

            //'R',   Modrm.reg encoded memory.
            mR,

            // 'M',   Modrm.rm encoded memory (always).
            mM,

            //'1',   Constant 1.
            One,

            //'C',   CL register.
            CL,

            //'M',   Modrm.rm encoded FPU register.
            STi
        }
    }
}