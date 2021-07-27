//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public readonly struct JccCodes
    {
        public enum AsmRelKind : byte
        {
            None = 0,

            [Symbol("rel8")]
            Rel8=1,

            [Symbol("rel16")]
            Rel16=2,

            [Symbol("rel32")]
            Rel32=3
        }

        [SymSource]
        public enum Jcc8 : byte
        {
            None = 0,

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
            None = 0,

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

        public enum Jcc8S : byte
        {
            None = 0,

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

        public enum Jcc32S : byte
        {
            None = 0,

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