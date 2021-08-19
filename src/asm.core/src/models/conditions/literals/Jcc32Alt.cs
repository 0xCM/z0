//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct ConditionCodes
    {
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