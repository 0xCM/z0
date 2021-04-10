//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct AsmX
    {
        /// <summary>
        /// Specifies a '/r' token where r = 0..7
        /// </summary>
        [SymbolSource]
        public enum RegDigitToken : byte
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
    }
}