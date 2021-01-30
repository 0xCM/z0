//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Part;

    using KW = AsmOpCodeKeywordNames;

    [LiteralProvider]
    public readonly struct AsmOpCodeKeywordMeaning
    {
        /// <summary>
        /// Defines the meaning of <see cref='KW.NE'/>
        /// </summary>
        public const string NE = "Not encodable";

        /// <summary>
        /// Defines the meaning of <see cref='KW.NP'/>
        /// </summary>
        public const string NP = "Indicates the use of 66/F2/F3 prefixes (beyond those already part of the instructions opcode) are not allowed with the instruction";

        /// <summary>
        /// Defines the meaning of <see cref='KW.NFx'/>
        /// </summary>
        public const string NFx = "Indicates the use of F2/F3 prefixes (beyond those already part of the instructions opcode) are not allowed with the instruction.";

        /// <summary>
        /// Defines the meaning of <see cref='KW.Rexᕀ'/>
        /// </summary>
        public const string Rexᕀ = "";

        /// <summary>
        /// Defines the meaning of <see cref='REXㆍWᕀ'/>
        /// </summary>
        public const string REXㆍWᕀ = "";

        public const string ﾉr = "Indicates that the ModR/M byte of the instruction contains a register operand and an r/m operand";

        public const string ﾉ0 = "The ModR/M byte of the instruction uses only the r/m operand; The register field digit 0 provides an extension to the instruction's opcode";

        public const string ﾉ1 = "The ModR/M byte of the instruction uses only the r/m operand; The register field digit 1 provides an extension to the instruction's opcode";

        public const string ﾉ2 = "The ModR/M byte of the instruction uses only the r/m operand; The register field digit 2 provides an extension to the instruction's opcode";

        public const string ﾉ3 = "The ModR/M byte of the instruction uses only the r/m operand; The register field digit 3 provides an extension to the instruction's opcode";

        public const string ﾉ4 = "The ModR/M byte of the instruction uses only the r/m operand; The register field digit 4 provides an extension to the instruction's opcode";

        public const string ﾉ5 = "The ModR/M byte of the instruction uses only the r/m operand; The register field digit 5 provides an extension to the instruction's opcode";

        public const string ﾉ6 = "The ModR/M byte of the instruction uses only the r/m operand; The register field digit 6 provides an extension to the instruction's opcode";

        public const string ﾉ7 = "The ModR/M byte of the instruction uses only the r/m operand; The register field digit 7 provides an extension to the instruction's opcode";

        public const string cb = "A 1-byte value following the opcode to specify a code offset and/or new value for the code segment register.";

        public const string cw = "A 2-byte value following the opcode to specify a code offset and/or new value for the code segment register.";

        public const string cd = "A 4-byte value following the opcode to specify a code offset and/or new value for the code segment register.";

        public const string cp = "A 6-byte value following the opcode to specify a code offset and/or new value for the code segment register.";

        public const string co = "A 8-byte value following the opcode to specify a code offset and/or new value for the code segment register.";

        public const string ct = "A 10-byte value following the opcode to specify a code offset and/or new value for the code segment register";

        public const string ib = "A 1-byte immediate operand to the instruction that follows the opcode or ModR/M bytes or scale-indexing bytes.";

        public const string iw = "A 2-byte immediate operand to the instruction that follows the opcode or ModR/M bytes or scale-indexing bytes.";

        public const string id = "A 4-byte immediate operand to the instruction that follows the opcode or ModR/M bytes or scale-indexing bytes.";

        public const string io = "A 8-byte immediate operand to the instruction that follows the opcode or ModR/M bytes or scale-indexing bytes.";

        public const string ᕀrb = "For an 8-bit register in non-64-bit mode, a register code is arithmetically added to the value of the opcode byte, and in 64-bit mode, the four bit field of REX.b and opcode[2:0] field encodes the register operand of the instruction";

        public const string ᕀrw = "For a 16-bit register, in non-64-bit mode, a register code is arithmetically added to the value of the opcode byte, and in 64-bit mode, the four bit field of REX.b and opcode[2:0] field encodes the register operand of the instruction";

        public const string ᕀrd = "For a 32-bit register, in non-64-bit mode, a register code is arithmetically added to the value of the opcode byte, and In 64-bit mode, the four bit field of REX.b and opcode[2:0] field encodes the register operand of the instruction";

        public const string ᕀro = "For a 64-bit register, indicates the four bit field of REX.b and opcode[2:0] field encodes the register operand of the instruction";

        public const string ᕀi = "A number used in floating-point instructions when one of the operands is ST(i) from the FPU register stack.";
    }
}