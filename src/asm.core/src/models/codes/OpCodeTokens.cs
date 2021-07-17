//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct AsmCodes
    {
        [SymSource]
        public enum PrefixToken : byte
        {
            [Symbol("66")]
            x66,

            [Symbol("F2")]
            F2,

            [Symbol("F3")]
            F3,

            [Symbol("0F")]
            x0F,

            [Symbol("0F38")]
            x0F38,

            [Symbol("VEX")]
            VEX,

            [Symbol("REX")]
            Rex,

            [Symbol("REX.W")]
            RexW,

            [Symbol("REX.R", "Modifies the ModR/M reg field when that field encodes a GPR, SSE, control or debug register. REX.R is ignored when ModR/M specifies other registers or defines an extended opcode")]
            RexR,

            [Symbol("REX.X", "Modifies the SIB index field")]
            RexX,

            [Symbol("REX.B", "Modifies the base in the ModR/M r/m field or SIB base field; or it modifies the opcode reg field used for accessing GPRs")]
            RexB,

            [Symbol("LZ")]
            LZ,

            [Symbol("LIG")]
            LIG,

            [Symbol("WIG")]
            WIG,

            [Symbol("W0")]
            W0,

            [Symbol("W1")]
            W1,
        }

        [SymSource]
        public enum OffsetToken : byte
        {
            [Symbol("cb", "Indicates a 1-byte value follows the opcode to specify a code offset and/or new value for the code segment register")]
            cb,

            [Symbol("cw", "Indicates a 2-byte value follows the opcode to specify a code offset and/or new value for the code segment register")]
            cw,

            [Symbol("cd", "Indicates a 4-byte value follows the opcode to specify a code offset and/or new value for the code segment register")]
            cd,

            [Symbol("cp", "Indicates a 6-byte value follows the opcode to specify a code offset and/or new value for the code segment register")]
            cp,

            [Symbol("co", "Indicates an 8-byte value follows the opcode to specify a code offset and/or new value for the code segment register")]
            co,

            [Symbol("ct", "Indicates a 10-byte value follows the opcode to specify a code offset and/or new value for the code segment register")]
            ct,
        }

        [SymSource]
        public enum SegOverrideToken : byte
        {
            [Symbol("cs", "CS segment override")]
            CS,

            [Symbol("ss", "SS segment override")]
            SS,

            [Symbol("ds", "DS segment override")]
            DS,

            [Symbol("es", "ES segment override")]
            ES,

            [Symbol("fs", "FS segment override")]
            FS,

            [Symbol("gs", "GS segment override")]
            GS,
        }

        /// <summary>
        /// "Specifies a '/r' token where r = 0..7. A digit between 0 and 7 indicates that the ModR/M byte of the instruction uses only the r/m (register or memory) operand. The reg field contains the digit that provides an extension to the instruction's opcode."
        /// </summary>
        [SymSource]
        public enum ModRmToken : byte
        {
            [Symbol("/r", "Indicates that the ModR/M byte of the instruction contains a register operand and an r/m operand")]
            r,

            [Symbol("/0", "Indicates the ModR/M byte of the instruction uses only the r/m operand; The register field digit 0 provides an extension to the instruction's opcode")]
            r0,

            [Symbol("/1", "The ModR/M byte of the instruction uses only the r/m operand; The register field digit 1 provides an extension to the instruction's opcode")]
            r1,

            [Symbol("/2", "The ModR/M byte of the instruction uses only the r/m operand; The register field digit 2 provides an extension to the instruction's opcode")]
            r2,

            [Symbol("/3", "The ModR/M byte of the instruction uses only the r/m operand; The register field digit 3 provides an extension to the instruction's opcode")]
            r3,

            [Symbol("/4", "The ModR/M byte of the instruction uses only the r/m operand; The register field digit 4 provides an extension to the instruction's opcode")]
            r4,

            [Symbol("/5", "The ModR/M byte of the instruction uses only the r/m operand; The register field digit 5 provides an extension to the instruction's opcode")]
            r5,

            [Symbol("/6", "The ModR/M byte of the instruction uses only the r/m operand; The register field digit 6 provides an extension to the instruction's opcode")]
            r6,

            [Symbol("/7", "The ModR/M byte of the instruction uses only the r/m operand; The register field digit 7 provides an extension to the instruction's opcode")]
            r7,
        }

        [SymSource("Indicates the lower 3 bits of the opcode byte is used to encode the register operand without a modR/M byte")]
        public enum RexBToken
        {
            [Symbol("None", "Indicates that REX.B in not applicable")]
            None = 0,

            [Symbol("+rb", "For an 8-bit register, indicates the four bit field of REX.b and opcode[2:0] field encodes the register operand of the instruction")]
            rb = 1,

            [Symbol("+rw", "For a 16-bit register, indicates the four bit field of REX.b and opcode[2:0] field encodes the register operand of the instruction")]
            rw = 2,

            [Symbol("+rd", "For a 32-bit register, indicates the four bit field of REX.b and opcode[2:0] field encodes the register operand of the instruction")]
            rd = 3,

            [Symbol("+ro", "For a 64-bit register, indicates the four bit field of REX.b and opcode[2:0] field encodes the register operand of the instruction")]
            ro = 4,

            [Symbol("N.A.", "Indicates that REX.B is not applicable")]
            NA = 5,

            [Symbol("N.E.", "Indicates that REX.B is not encodable")]
            NE = 6,
        }

        [SymSource("Specifies the size of an immediate operand in the context of an opcode specification")]
        public enum ImmSizeToken : byte
        {
            [Symbol("ib", "Indicates a 1-byte immediate operand to the instruction that follows the opcode or ModR/M bytes or scale-indexing bytes.")]
            ib,

            [Symbol("iw", "Indicates a 2-byte immediate operand to the instruction that follows the opcode or ModR/M bytes or scale-indexing bytes.")]
            iw,

            [Symbol("id", "Indicates a 4-byte immediate operand to the instruction that follows the opcode or ModR/M bytes or scale-indexing bytes.")]
            id,

            [Symbol("io", "Indicates An 8-byte immediate operand to the instruction that follows the opcode or ModR/M bytes or scale-indexing bytes")]
            io,
        }

        [SymSource]
        public enum FpuToken : byte
        {
            [Symbol("+0")]
            i0,

            [Symbol("+1")]
            i1,

            [Symbol("+2")]
            i2,

            [Symbol("+3")]
            i3,

            [Symbol("+4")]
            i4,

            [Symbol("+5")]
            i5,

            [Symbol("+6")]
            i6,

            [Symbol("+7")]
            i7,
        }

        [SymSource]
        public enum ExclusionToken
        {
            [Symbol("NP", " Indicates the use of 66/F2/F3 prefixes are not allowed with the instruction")]
            NP = 0,

            [Symbol("NFx", "Indicates the use of F2/F3 prefixes are not allowed with the instruction")]
            NFx = 1,
        }
    }
}