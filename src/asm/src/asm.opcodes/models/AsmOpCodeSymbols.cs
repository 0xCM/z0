//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public readonly struct AsmOpCodeSymbols
    {
        /// <summary>
        /// Not encodable
        /// </summary>
        public static AsmOpCodeSymbol NE = "NE";

        /// <summary>
        /// Indicates the use of 66/F2/F3 prefixes (beyond those already part of the instructions opcode) are not allowed with the instruction
        /// </summary>
        public static AsmOpCodeSymbol NP = "NP";

        /// <summary>
        /// Indicates the use of F2/F3 prefixes (beyond those already part of the instructions opcode) are not allowed with the instruction.
        /// </summary>
        public static AsmOpCodeSymbol NFx = "NFx";

        /// <summary>
        /// Indicates the use of a REX prefix that affects operand size or instruction semantics
        /// </summary>
        public static AsmOpCodeSymbol REXᕀW = "REX.W";

        /// <summary>
        /// Indicates that the ModR/M byte of the instruction contains a register operand and an r/m operand
        /// </summary>
        public static AsmOpCodeSymbol ﾉr = "/r";

        /// <summary>
        /// Indicates the ModR/M byte of the instruction uses only the r/m operand; The register field digit 0 provides an extension to the instruction's opcode
        /// </summary>
        public static AsmOpCodeSymbol ﾉ0 = "/0";

        /// <summary>
        /// Indicates the ModR/M byte of the instruction uses only the r/m operand; The register field digit 1 provides an extension to the instruction's opcode
        /// </summary>
        public static AsmOpCodeSymbol ﾉ1 = "/1";

        /// <summary>
        /// Indicates the ModR/M byte of the instruction uses only the r/m operand; The register field digit 2 provides an extension to the instruction's opcode
        /// </summary>
        public static AsmOpCodeSymbol ﾉ2 = "/2";

        /// <summary>
        /// Indicates the ModR/M byte of the instruction uses only the r/m operand; The register field digit 3 provides an extension to the instruction's opcode
        /// </summary>
        public static AsmOpCodeSymbol ﾉ3 = "/3";

        /// <summary>
        /// Indicates the ModR/M byte of the instruction uses only the r/m operand; The register field digit 4 provides an extension to the instruction's opcode
        /// </summary>
        public static AsmOpCodeSymbol ﾉ4 = "/4";

        /// <summary>
        /// Indicates the ModR/M byte of the instruction uses only the r/m operand; The register field digit 5 provides an extension to the instruction's opcode
        /// </summary>
        public static AsmOpCodeSymbol ﾉ5 = "/5";

        /// <summary>
        /// Indicates the ModR/M byte of the instruction uses only the r/m operand; The register field digit 6 provides an extension to the instruction's opcode
        /// </summary>
        public static AsmOpCodeSymbol ﾉ6 = "/6";

        /// <summary>
        /// Indicates the ModR/M byte of the instruction uses only the r/m operand; The register field digit 7 provides an extension to the instruction's opcode
        /// </summary>
        public static AsmOpCodeSymbol ﾉ7 = "/7";

        /// <summary>
        /// Represents a 1-byte value following the opcode to specify a code offset and/or new value for the code segment register.
        /// </summary>
        public static AsmOpCodeSymbol cb = "cb";

        /// <summary>
        /// Represents a 2-byte value following the opcode to specify a code offset and/or new value for the code segment register.
        /// </summary>
        public static AsmOpCodeSymbol cw = "cw";

        /// <summary>
        /// Represents a 4-byte value following the opcode to specify a code offset and/or new value for the code segment register.
        /// </summary>
        public static AsmOpCodeSymbol cd = "cd";

        /// <summary>
        /// Represents a 6-byte value following the opcode to specify a code offset and/or new value for the code segment register.
        /// </summary>
        public static AsmOpCodeSymbol cp = "cp";

        /// <summary>
        /// Represents an 8-byte value following the opcode to specify a code offset and/or new value for the code segment register.
        /// </summary>
        public static AsmOpCodeSymbol co = "co";

        /// <summary>
        /// Represents a 10-byte value following the opcode to specify a code offset and/or new value for the code segment register
        /// </summary>
        public static AsmOpCodeSymbol ct = "ct";

        /// <summary>
        /// A 1-byte immediate operand to the instruction that follows the opcode or ModR/M bytes or scale-indexing bytes.
        /// </summary>
        public static AsmOpCodeSymbol ib = "ib";

        /// <summary>
        /// A 2-byte immediate operand to the instruction that follows the opcode or ModR/M bytes or scale-indexing bytes.
        /// </summary>
        public static AsmOpCodeSymbol iw = "iw";

        /// <summary>
        /// A 4-byte immediate operand to the instruction that follows the opcode or ModR/M bytes or scale-indexing bytes.
        /// </summary>
        public static AsmOpCodeSymbol id = "id";

        /// <summary>
        /// A 8-byte immediate operand to the instruction that follows the opcode or ModR/M bytes or scale-indexing bytes.
        /// </summary>
        public static AsmOpCodeSymbol io = "io";

        /// <summary>
        /// For an 8-bit register indicates:
        /// (a) In non-64-bit mode, a register code is arithmetically added to the value of the opcode byte.
        /// (b) In 64-bit mode, the four bit field of REX.b and opcode[2:0] field encodes the register operand of the instruction
        /// </summary>
        public static AsmOpCodeSymbol ᕀrb = "+rb";

        /// <summary>
        /// For a 16-bit register indicates:
        /// (a) In non-64-bit mode, a register code is arithmetically added to the value of the opcode byte.
        /// (b) In 64-bit mode, the four bit field of REX.b and opcode[2:0] field encodes the register operand of the instruction
        /// </summary>
        public static AsmOpCodeSymbol ᕀrw = "+rw";

        /// <summary>
        /// For a 32-bit register indicates:
        /// (a) In non-64-bit mode, a register code is arithmetically added to the value of the opcode byte.
        /// (b) In 64-bit mode, the four bit field of REX.b and opcode[2:0] field encodes the register operand of the instruction
        /// </summary>
        public static AsmOpCodeSymbol ᕀrd = "+rd";

        /// <summary>
        /// For a 64-bit register, indicates the four bit field of REX.b and opcode[2:0] field encodes the register operand of the instruction
        /// </summary>
        public static AsmOpCodeSymbol ᕀro = "+ro";

        /// <summary>
        /// A number used in floating-point instructions when one of the operands is ST(i) from the FPU register stack.
        /// </summary>
        public static AsmOpCodeSymbol ᕀi = "+i";
    }
}