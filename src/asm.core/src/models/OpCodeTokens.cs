//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct AsmCodes
    {
        [SymbolSource]
        public enum PrefixToken : byte
        {
            [Symbol("66")]
            x66 = 0,

            [Symbol("F2")]
            F2 = 1,

            [Symbol("F3")]
            F3 = 2,

            [Symbol("0F")]
            x0F = 3,

            [Symbol("0F38")]
            x0F38 = 4,

            [Symbol("VEX")]
            VEX = 5,

            [Symbol("REX")]
            Rex = 6,

            [Symbol("REX.W")]
            RexW = 7,

            [Symbol("LZ")]
            LZ = 8,

            [Symbol("LIG")]
            LIG = 9,

            [Symbol("WIG")]
            WIG = 10,

            [Symbol("W0")]
            W0 = 11,

            [Symbol("W1")]
            W1 = 12,
        }

        [SymbolSource]
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

        [SymbolSource]
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
        [SymbolSource]
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

        [SymbolSource("Indicates the lower 3 bits of the opcode byte is used to encode the register operand without a modR/M byte")]
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

        [SymbolSource("Specifies the size of an immediate operand in the context of an opcode specification")]
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

        [SymbolSource]
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

        [SymbolSource]
        public enum ExclusionToken
        {
            [Symbol("NP", " Indicates the use of 66/F2/F3 prefixes are not allowed with the instruction")]
            NP = 0,

            [Symbol("NFx", "Indicates the use of F2/F3 prefixes are not allowed with the instruction")]
            NFx = 1,
        }
    }
}