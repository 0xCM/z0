//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct ConditionCodes
    {
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

            [Symbol("jbe", "Jump short if below or equal (CF=1 | ZF=1)")]
            JBE = 0x76,

            [Symbol("jnbe", "Jump short if not below or equal (CF=0 & ZF=0)")]
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

            [Symbol("jle", "Jump short if less or equal (ZF=1 | SF!=OF)")]
            JLE = 0x7E,

            [Symbol("jg", "Jump short if greater (ZF=0 & SF=OF)")]
            JG = 0x7F
        }
    }
}