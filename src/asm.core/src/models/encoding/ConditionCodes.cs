//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using static BitSeq;

    public readonly struct ConditionCodes
    {
        public enum ActionCode : byte
        {
            None =0,

            Jmp = 1,

            Mov = 2
        }

        public readonly struct ConditionFacets
        {
            public const byte ConditionCount = 16;

            public const byte Jcc8Base = 0x70;

            public const byte Jcc32Base = 0x80;
        }

        /// <summary>
        /// Defines the condition codes as the bitfield [tttn] where ttt indicates
        /// the condition being tested and n indicates where to use the condition (n=0)
        /// or its negation (n=1). For 1-byte primary opcodes, the tttn field is located
        /// in bits 3, 2, 1, and 0 of the opcode byte. For 2-byte primary opcodes, the tttn
        /// field is located in bits 3, 2, 1, and 0 of the second opcode byte
        /// </summary>
        /// <remarks>
        /// From Vol2D, appendix B.1.4.7
        /// </remarks>
        [SymSource]
        public enum Condition : byte
        {
            /// <summary>
            /// Overflow
            /// </summary>
            [Symbol("O", "Overflow")]
            O = b0000,

            /// <summary>
            /// Not Overflow
            /// </summary>
            [Symbol("NO", "Not Overflow")]
            NO = b0001,

            /// <summary>
            /// Below, not above or equal
            /// </summary>
            [Symbol("B", "Below")]
            B = b0010,

            /// <summary>
            /// Not Below
            /// </summary>
            [Symbol("NB", "Not Below")]
            NB = b0011,

            /// <summary>
            /// Equal; Zero
            /// </summary>
            [Symbol("E", "Equal")]
            E = b0100,

            /// <summary>
            /// Not Equal; Not Zero
            /// </summary>
            [Symbol("NE", "Not Equal")]
            NE = b0101,

            /// <summary>
            /// Below or equal, Not above
            /// </summary>
            [Symbol("BE", "Below or Equal")]
            BE = b0110,

            /// <summary>
            /// Not below or equal, Above
            /// </summary>
            [Symbol("NBE", "Not Below or Equal")]
            NBE = b0111,

            /// <summary>
            /// Sign
            /// </summary>
            [Symbol("S", "Sign")]
            S = b1000,

            /// <summary>
            /// Not sign
            /// </summary>
            [Symbol("NS", "Not Signed")]
            NS = b1001,

            /// <summary>
            /// Parity Even
            /// </summary>
            [Symbol("P", "Parity")]
            P = b1010,

            /// <summary>
            /// Parity Odd
            /// </summary>
            [Symbol("NP", "Not Parity")]
            NP = b1011,

            /// <summary>
            /// Less than; Not greater than or equal to
            /// </summary>
            [Symbol("LT", "Less Than")]
            LT = b1100,

            /// <summary>
            /// Not less than, Greater than or equal to
            /// </summary>
            [Symbol("NLT", "Not Less Than")]
            NLT = b1101,

            /// <summary>
            /// Less Than or Equal
            /// </summary>
            [Symbol("LE", "Less Than or Equal")]
            LE = b1110,

            /// <summary>
            /// Not Less Than or Equal
            /// </summary>
            [Symbol("NLE", "Not Less Than or Equal")]
            NLE = b1111,
        }

        [SymSource]
        public enum ConditionAlt : byte
        {
            /// <summary>
            /// Overflow
            /// </summary>
            [Symbol("O", "Overflow")]
            O = b0000,

            /// <summary>
            /// Not Overflow
            /// </summary>
            [Symbol("NO", "Not Overflow")]
            NO = b0001,

            /// <summary>
            /// Below, not above or equal
            /// </summary>
            [Symbol("NAE", "Not Above or Equal")]
            NAE = b0010,

            /// <summary>
            /// Not Below
            /// </summary>
            [Symbol("AE", "Above or Equal")]
            AE = b0011,

            /// <summary>
            /// Equal; Zero
            /// </summary>
            [Symbol("Z", "Zero")]
            Z = b0100,

            /// <summary>
            /// Not Equal; Not Zero
            /// </summary>
            [Symbol("NZ", "Not Zero")]
            NZ = b0101,

            /// <summary>
            /// Below or equal, Not above
            /// </summary>
            [Symbol("NA", "Not Above")]
            NA = b0110,

            /// <summary>
            /// Not below or equal, Above
            /// </summary>
            [Symbol("A", "Above")]
            A = b0111,

            /// <summary>
            /// Sign
            /// </summary>
            [Symbol("S", "Sign")]
            S = b1000,

            /// <summary>
            /// Not sign
            /// </summary>
            [Symbol("NS", "Not Signed")]
            NS = b1001,

            /// <summary>
            /// Parity Even
            /// </summary>
            [Symbol("PE", "Parity Even")]
            PE = b1010,

            /// <summary>
            /// Parity Odd
            /// </summary>
            [Symbol("PO", "Parity Odd)")]
            PO = b1011,

            /// <summary>
            /// Less than; Not greater than or equal to
            /// </summary>
            [Symbol("NGE", " Not Greater Than or Equal")]
            NGE = b1100,

            /// <summary>
            /// Not less than, Greater than or equal to
            /// </summary>
            [Symbol("GE", "Greater Than or Equal")]
            GE = b1101,

            /// <summary>
            /// Less than or equal to, Not greater than
            /// </summary>
            [Symbol("NGT", "Not Greater Than")]
            NGT = b1110,

            /// <summary>
            /// Not less than or equal to, Greater than
            /// </summary>
            [Symbol("GT", "Greater Than")]
            GT = b1111,
        }

        [SymSource]
        public enum Jcc8 : byte
        {
            [Symbol("jo", "Jump short if overflow (OF=1)")]
            JO = 0x70,

            [Symbol("jno", "Jump short if not overflow (OF=0)")]
            JNO = 0x71,

            [Symbol("jb", "Jump short if below (CF=1)")]
            JB = 0x72,

            [Symbol("jnb", "Jump short if not below (CF=0)")]
            JNB = 0x73,

            [Symbol("jz", "Jump short if zero (ZF = 1)")]
            JZ = 0x74,

            [Symbol("jnz", "Jump short if not zero (ZF=0)")]
            JNZ = 0x75,

            [Symbol("jna", "Jump short if not above (CF=1 or ZF=1)")]
            JNA = 0x76,

            [Symbol("ja", "Jump short if above (CF=0 and ZF=0)")]
            JA = 0x77,

            [Symbol("js", "Jump short if sign (SF=1)")]
            JS = 0x78,

            [Symbol("jns", "Jump short if not sign (SF=0)")]
            JNS = 0x79,

            [Symbol("jpe", "Jump short if parity even (PF=1)")]
            JPE = 0x7A,

            [Symbol("jpo", "Jump short if parity odd (PF=0)")]
            JPO = 0x7B,

            [Symbol("jl", "Jump short if less (SF != OF)")]
            JL = 0x7C,

            [Symbol("jnl", "Jump short if not less (SF=OF)")]
            JNL = 0x7D,

            [Symbol("jng", "Jump short if not greater (ZF=1 or SF!=OF)")]
            JNG = 0x7E,

            [Symbol("jnle", "Jump short if not less or equal (ZF=0 and SF=OF)")]
            JNLE = 0x7F,
        };

        [SymSource]
        public enum Jcc32 : byte
        {
            [Symbol("jo", "Jump near if overflow (OF=1)")]
            JO = 0x80,

            [Symbol("jno", "Jump near if not overflow (OF=0)")]
            JNO = 0x81,

            [Symbol("jb", "Jump near if below (CF=1)")]
            JB = 0x82,

            [Symbol("jnb", "Jump near if not below (CF=0)")]
            JNB = 0x83,

            [Symbol("jz", "Jump near if zero (ZF = 1)")]
            JZ = 0x84,

            [Symbol("jnz", "Jump near if not zero (ZF=0)")]
            JNZ = 0x85,

            [Symbol("jna", "Jump near if not above (CF=1 or ZF=1)")]
            JNA = 0x86,

            [Symbol("ja", "Jump near if above (CF=0 and ZF=0)")]
            JA = 0x87,

            [Symbol("js", "Jump near if sign (SF=1)")]
            JS = 0x88,

            [Symbol("jns", "Jump near if not sign (SF=0)")]
            JNS = 0x89,

            [Symbol("jpe", "Jump near if parity even (PF=1)")]
            JPE = 0x8A,

            [Symbol("jpo", "Jump near if parity odd (PF=0)")]
            JPO = 0x8B,

            [Symbol("jl", "Jump near if less (SF != OF)")]
            JL = 0x8C,

            [Symbol("jnl", "Jump near if not less (SF=OF)")]
            JNL = 0x8D,

            [Symbol("jng", "Jump near if not greater (ZF=1 or SF!=OF)")]
            JNG = 0x8E,

            [Symbol("jnle", "Jump near if not less or equal (ZF=0 and SF=OF)")]
            JNLE = 0x8F,
        };

        [SymSource]
        public enum Jcc8Alt : byte
        {
            [Symbol("jo", "Jump short if overflow (OF=1)")]
            JO = 0x70,

            [Symbol("jno", "Jump short if not overflow (OF=0)")]
            JNO = 0x71,

            [Symbol("jnae", "Jump short if not above or equal (CF=1)")]
            JNAE = 0x72,

            [Symbol("jae", "Jump short if above or equal (CF=0)")]
            JAE = 0x73,

            [Symbol("je", "Jump short if equal (ZF=1)")]
            JE = 0x74,

            [Symbol("jne", "Jump short if not equal (ZF=0)")]
            JNE = 0x75,

            [Symbol("jbe", "Jump short if below or equal (CF=1 or ZF=1)")]
            JBE = 0x76,

            [Symbol("jnbe", "Jump short if not below or equal (CF=0 and ZF=0)")]
            JNBE = 0x77,

            [Symbol("js", "Jump short if sign (SF=1)")]
            JS = 0x78,

            [Symbol("jns", "Jump short if not sign (SF=0)")]
            JNS = 0x79,

            [Symbol("jp", "Jump short if parity (PF=1)")]
            JP = 0x7A,

            [Symbol("jnp", "Jump short if not parity (PF=0)")]
            JNP = 0x7B,

            [Symbol("jnge", "Jump short if not greater or equal (SF!=OF)")]
            JNGE = 0x7C,

            [Symbol("jge", "Jump short if greater or equal (SF=OF)")]
            JGE = 0x7D,

            [Symbol("jle", "Jump short if less or equal (ZF=1 or SF!=OF)")]
            JLE = 0x7E,

            [Symbol("jg", "Jump short if greater (ZF=0 and SF=OF)")]
            JG = 0x7F
        }

        [SymSource]
        public enum Jcc32Alt : byte
        {
            [Symbol("jo", "Jump near if overflow (OF=1)")]
            JO = 0x80,

            [Symbol("jno", "Jump near if not overflow (OF=0)")]
            JNO = 0x81,

            [Symbol("jnae", "Jump near if not above or equal (CF=1)")]
            JNAE = 0x82,

            [Symbol("jae", "Jump near if above or equal (CF=0)")]
            JAE = 0x83,

            [Symbol("je", "Jump near if equal (ZF=1)")]
            JE = 0x84,

            [Symbol("jne", "Jump near if not equal (ZF=0)")]
            JNE = 0x85,

            [Symbol("jbe", "Jump near if below or equal (CF=1 or ZF=1)")]
            JBE = 0x86,

            [Symbol("jnbe", "Jump near if not below or equal (CF=0 and ZF=0)")]
            JNBE = 0x87,

            [Symbol("js", "Jump near if sign (SF=1)")]
            JS = 0x88,

            [Symbol("jns", "Jump near if not sign (SF=0)")]
            JNS = 0x89,

            [Symbol("jp", "Jump near if parity (PF=1)")]
            JP = 0x8A,

            [Symbol("jnp", "Jump near if not parity (PF=0)")]
            JNP = 0x8B,

            [Symbol("jnge", "Jump near if not greater or equal (SF!=OF)")]
            JNGE = 0x8C,

            [Symbol("jge", "Jump near if greater or equal (SF=OF)")]
            JGE = 0x8D,

            [Symbol("jle", "Jump near if less or equal (ZF=1 or SF!=OF)")]
            JLE = 0x8E,

            [Symbol("jg", "Jump near if greater (ZF=0 and SF=OF)")]
            JG = 0x8F
        }
    }
}