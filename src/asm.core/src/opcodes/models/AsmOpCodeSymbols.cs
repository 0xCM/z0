//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using static AsciCode;

    public readonly struct AsmOpCodeSymbols
    {
        [Flags]
        public enum TokenKind : byte
        {
            None = 0,

            Offset = 1,

            Prefix = 2,

            OpCodeExt = 4,

            OpCodeMod = 8,

            ImmSize = 16,

            [Symbol("Indicates the ModR/M byte of the instruction contains a register operand and an r/m operand")]
            RM = 32,
        }

        [SymbolSource]
        public enum Offset : byte
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

        public const string PrefixText = "66F2F30F0F38VEXREXREX.WLZLIGWIGW0W1";

        public const byte PrefixCount = 13;

        public static ReadOnlySpan<byte> PrefixIndexList => new byte[PrefixCount]{0,2,4,6,8,12,15,18,22,24,25,28,31};

        public static ReadOnlySpan<byte> PrefixSymbolLengths => new byte[PrefixCount]{2,2,2,2,4,3,3,5,2,3,3,2,2};

        public static ReadOnlySpan<AsciCode> PrefixData => new AsciCode[35]{d6, d6, F, d2, F, d3, d0, F, d0, F, d3, d8, V, E, X, R, E, X, R, E, X, Dot, W, L, Z, L, I, G, W, I, G, W, d0, W, d1};

        [SymbolSource]
        public enum Prefix : byte
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

        /// <summary>
        /// Specifies a '/r' token where r = 0..7. A digit between 0 and 7 indicates that the ModR/M byte of the instruction uses only
        /// the r/m (register or memory) operand. The reg field contains the digit that provides an extension to the instruction's opcode.
        /// </summary>
        [SymbolSource]
        public enum RegDigit : byte
        {
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

        /// <summary>
        /// Specifies symbols that modify the op code value
        /// </summary>
        [SymbolSource]
        public enum OpCodeMod : byte
        {
            [Symbol("+rb", "For an 8-bit register, indicates the lower 3 bits of the opcode byte is used to encode the register operand without a modR/M byte")]
            rb,

            [Symbol("+rw", "For a 16-bit register, in non-64-bit mode, a register code is arithmetically added to the value of the opcode byte, and in 64-bit mode, the four bit field of REX.b and opcode[2:0] field encodes the register operand of the instruction")]
            rw,

            [Symbol("+rd", "For a 32-bit register, in non-64-bit mode, a register code is arithmetically added to the value of the opcode byte, and In 64-bit mode, the four bit field of REX.b and opcode[2:0] field encodes the register operand of the instruction")]
            rd,

            [Symbol("+ro", "For a 64-bit register, indicates the four bit field of REX.b and opcode[2:0] field encodes the register operand of the instruction")]
            ro,
        }

        /// <summary>
        /// Specifies the size of an immediate operand in the context of an opcode specification
        /// </summary>
        [SymbolSource]
        public enum ImmSize : byte
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

        internal static ReadOnlySpan<Offset> Offsets
            => new Offset[]{Offset.cb, Offset.cw, Offset.cd, Offset.cp, Offset.co, Offset.ct};

        internal static ReadOnlySpan<RegDigit> RegDigits
            => new RegDigit[]{RegDigit.r0, RegDigit.r1,RegDigit.r2,RegDigit.r3,RegDigit.r4,RegDigit.r5,RegDigit.r6,RegDigit.r7,};

        internal static ReadOnlySpan<Prefix> Prefixes
            => new Prefix[]{Prefix.x66,Prefix.F2,Prefix.F3,Prefix.x0F,Prefix.x0F38, Prefix.Rex,
                    Prefix.RexW, Prefix.VEX, Prefix.LZ,Prefix.LIG, Prefix.WIG, Prefix.W0, Prefix.W1};
    }
}