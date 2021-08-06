//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public readonly struct AsmOpCodeTokens
    {
        public enum TokenKind : byte
        {
            /// <summary>
            /// Classifies the untoken
            /// </summary>
            None = 0,

            /// <summary>
            /// Classifies the 256 literal hex bytes [0xOO, 0x01, ..., 0xFF]
            /// </summary>
            [Symbol("literal")]
            Byte,

            /// <summary>
            /// Classifies <see cref='RexToken'/> tokens
            /// </summary>
            [Symbol("rex")]
            Rex,

            /// <summary>
            /// Classifies <see cref='VexToken'/> tokens
            /// </summary>
            [Symbol("vex")]
            Vex,

            /// <summary>
            /// Classifies <see cref='EvexToken'/> tokens
            /// </summary>
            [Symbol("evex")]
            Evex,

            /// <summary>
            /// Classifies <see cref='LegacyPrefixToken'/> tokens
            /// </summary>
            LegacyPrefix,

            /// <summary>
            /// Classifies <see cref='RexBToken'/> tokens
            /// </summary>
            [Symbol("rex(b)")]
            RexBExtension,

            /// <summary>
            /// Classifies <see cref='ModRmToken'/> tokens
            /// </summary>
            RegOpCodeMod,

            /// <summary>
            /// Classifies <see cref='SegOverrideToken'/> tokens
            /// </summary>
            SegOverride,

            /// <summary>
            /// Classifies <see cref='DispToken'/> tokens
            /// </summary>
            [Symbol("disp")]
            Disp,

            /// <summary>
            /// Classifies <see cref='ImmSizeToken'/> tokens
            /// </summary>
            ImmSize,

            /// <summary>
            /// Classifies <see cref='ExclusionToken'/> tokens
            /// </summary>
            Exclusion,

            /// <summary>
            /// Classifies <see cref='FpuDigitToken'/> tokens
            /// </summary>
            FpuDigit,

            /// <summary>
            /// Classifies <see cref='MaskToken'/> tokens
            /// </summary>
            Mask,

            /// <summary>
            /// Classifies <see cref='OperatorToken'/> tokens
            /// </summary>
            Operator,
        }

        [FieldSeg(0,4), SymSource]
        public enum LegacyPrefixToken : byte
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
        }

        [SymSource]
        public enum RexToken : byte
        {
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
        }

        [SymSource]
        public enum VexToken : byte
        {
            [Symbol("VEX")]
            VEX,

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

            [Symbol("128")]
            W128,

            [Symbol("256")]
            W256,

            [Symbol("vvvv", "Indicates non-destructive source register encoding")]
            vvvv,

            [Symbol("mmmmm", "In a 3-byte vex prefix, indicates the least 5 bits of the middle byte")]
            mmmmm,
        }

        [SymSource]
        public enum EvexToken : byte
        {
            [Symbol("EVEX")]
            EVEX,

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

            [Symbol("128")]
            W128,

            [Symbol("256")]
            W256,

            [Symbol("512")]
            W512,
        }

        // "cb\0" + "cw\0" + "cd\0" + "cp\0" + "c0\0" + "ct\0"
        [FieldSeg(1,3), SymSource]
        public enum DispToken : byte
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

        [FieldSeg(2,3), SymSource]
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
        [FieldSeg(3,4), SymSource]
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

        [FieldSeg(4,3), SymSource("Indicates the lower 3 bits of the opcode byte is used to encode the register operand without a modR/M byte")]
        public enum RexBToken : byte
        {
            [Symbol("None", "Indicates that REX.B in not applicable")]
            None = 0,

            [Symbol("+rb", "For an 8-bit register, indicates the four bit field of REX.b and opcode[2:0] field encodes the register operand of the instruction")]
            rb,

            [Symbol("+rw", "For a 16-bit register, indicates the four bit field of REX.b and opcode[2:0] field encodes the register operand of the instruction")]
            rw,

            [Symbol("+rd", "For a 32-bit register, indicates the four bit field of REX.b and opcode[2:0] field encodes the register operand of the instruction")]
            rd,

            [Symbol("+ro", "For a 64-bit register, indicates the four bit field of REX.b and opcode[2:0] field encodes the register operand of the instruction")]
            ro,

            [Symbol("N.A.", "Indicates that REX.B is not applicable")]
            NA,

            [Symbol("N.E.", "Indicates that REX.B is not encodable")]
            NE,
        }

        [FieldSeg(5,3), SymSource("Specifies the size of an immediate operand in the context of an opcode specification")]
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

        [FieldSeg(6,3), SymSource]
        public enum FpuDigitToken : byte
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

        [FieldSeg(7,2), SymSource]
        public enum ExclusionToken
        {
            [Symbol("NP", " Indicates the use of 66/F2/F3 prefixes are not allowed with the instruction")]
            NP,

            [Symbol("NFx", "Indicates the use of F2/F3 prefixes are not allowed with the instruction")]
            NFx,
        }

        [SymSource]
        public enum MaskToken : byte
        {
            [Symbol("{k1}", "Indicates a mask register used as instruction writemask for instructions that do not allow zeroing-masking but support merging-masking")]
            Mask,

            [Symbol("{k1}{z}", "Indicates a mask register used as instruction writemask")]
            WriteMask,
        }

        [SymSource]
        public enum OperatorToken : byte
        {
            [Symbol("+")]
            Plus,

            [Symbol(".")]
            Dot,
        }
   }
}