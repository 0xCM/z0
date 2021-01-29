//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using KW = AsmOpCodeKeywordKeys;

    /// <summary>
    /// Gives a type to the literals defined by <see cref='AsmOpCodeKeywordKeys'/>
    /// </summary>
    public enum AsmOpCodeKeywordId : byte
    {
        /// <summary>
        /// Indicates the absence of a keyword specification
        /// </summary>
        None = 0,

        /// <summary>
        /// Not encodable
        /// </summary>
        NE = KW.NE,

        /// <summary>
        /// Indicates the use of 66/F2/F3 prefixes (beyond those already part of the instructions opcode) are not allowed with the instruction
        /// </summary>
        NP = KW.NP,

        /// <summary>
        /// Indicates the use of F2/F3 prefixes (beyond those already part of the instructions opcode) are not allowed with the instruction.
        /// </summary>
        NFx = KW.NFx,

        Rexᕀ = KW.REXᕀ,

        REXㆍWᕀ = KW.REXㆍWᕀ,

        /// <summary>
        /// Indicates that the ModR/M byte of the instruction contains a register operand and an r/m operand
        /// </summary>
        ﾉr = KW.ﾉr,

        /// <summary>
        /// The ModR/M byte of the instruction uses only the r/m operand; The register field digit 0 provides an extension to the instruction's opcode
        /// </summary>
        ﾉ0 = KW.ﾉ0,

        /// <summary>
        /// The ModR/M byte of the instruction uses only the r/m operand; The register field digit 1 provides an extension to the instruction's opcode
        /// </summary>
        ﾉ1 = KW.ﾉ1,

        /// <summary>
        /// The ModR/M byte of the instruction uses only the r/m operand; The register field digit 2 provides an extension to the instruction's opcode
        /// </summary>
        ﾉ2 = KW.ﾉ2,

        /// <summary>
        /// The ModR/M byte of the instruction uses only the r/m operand; The register field digit 3 provides an extension to the instruction's opcode
        /// </summary>
        ﾉ3 = KW.ﾉ3,

        /// <summary>
        /// The ModR/M byte of the instruction uses only the r/m operand; The register field digit 4 provides an extension to the instruction's opcode
        /// </summary>
        ﾉ4 = KW.ﾉ4,

        /// <summary>
        /// The ModR/M byte of the instruction uses only the r/m operand; The register field digit 5 provides an extension to the instruction's opcode
        /// </summary>
        ﾉ5 = KW.ﾉ5,

        /// <summary>
        /// The ModR/M byte of the instruction uses only the r/m operand; The register field digit 6 provides an extension to the instruction's opcode
        /// </summary>
        ﾉ6 = KW.ﾉ6,

        /// <summary>
        /// The ModR/M byte of the instruction uses only the r/m operand; The register field digit 7 provides an extension to the instruction's opcode
        /// </summary>
        ﾉ7 = KW.ﾉ7,

        /// <summary>
        /// A 1-byte value following the opcode to specify a code offset and/or new value for the code segment register.
        /// </summary>
        cb = KW.cb,

        /// <summary>
        /// A 2-byte value following the opcode to specify a code offset and/or new value for the code segment register.
        /// </summary>
        cw = KW.cw,

        /// <summary>
        /// A 4-byte value following the opcode to specify a code offset and/or new value for the code segment register.
        /// </summary>
        cd = KW.cd,

        /// <summary>
        /// A 6-byte value following the opcode to specify a code offset and/or new value for the code segment register.
        /// </summary>
        cp = KW.cp,

        /// <summary>
        /// A 8-byte value following the opcode to specify a code offset and/or new value for the code segment register.
        /// </summary>
        co = KW.co,

        /// <summary>
        /// A 10-byte value following the opcode to specify a code offset and/or new value for the code segment register
        /// </summary>
        ct = KW.ct,

        /// <summary>
        /// A 1-byte immediate operand to the instruction that follows the opcode or ModR/M bytes or scale-indexing bytes.
        /// </summary>
        ib = KW.ib,

        /// <summary>
        /// A 2-byte immediate operand to the instruction that follows the opcode or ModR/M bytes or scale-indexing bytes.
        /// </summary>
        iw = KW.iw,

        /// <summary>
        /// A 4-byte immediate operand to the instruction that follows the opcode or ModR/M bytes or scale-indexing bytes.
        /// </summary>
        id = KW.id,

        /// <summary>
        /// A 8-byte immediate operand to the instruction that follows the opcode or ModR/M bytes or scale-indexing bytes.
        /// </summary>
        io = KW.io,

        /// <summary>
        /// For an 8-bit register indicates:
        /// (a) In non-64-bit mode, a register code is arithmetically added to the value of the opcode byte.
        /// (b) In 64-bit mode, the four bit field of REX.b and opcode[2:0] field encodes the register operand of the instruction
        /// </summary>
        ᕀrb = KW.ᕀrb,

        /// <summary>
        /// For a 16-bit register indicates:
        /// (a) In non-64-bit mode, a register code is arithmetically added to the value of the opcode byte.
        /// (b) In 64-bit mode, the four bit field of REX.b and opcode[2:0] field encodes the register operand of the instruction
        /// </summary>
        ᕀrw = KW.ᕀrw,

        /// <summary>
        /// For a 32-bit register indicates:
        /// (a) In non-64-bit mode, a register code is arithmetically added to the value of the opcode byte.
        /// (b) In 64-bit mode, the four bit field of REX.b and opcode[2:0] field encodes the register operand of the instruction
        /// </summary>
        ᕀrd = KW.ᕀrd,

        /// <summary>
        /// For a 64-bit register, indicates the four bit field of REX.b and opcode[2:0] field encodes the register operand of the instruction
        /// </summary>
        ᕀro = KW.ᕀro,

        /// <summary>
        /// A number used in floating-point instructions when one of the operands is ST(i) from the FPU register stack.
        /// </summary>
        ᕀi = KW.ᕀi,
    }
}