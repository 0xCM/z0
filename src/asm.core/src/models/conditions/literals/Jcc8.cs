//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct ConditionCodes
    {
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

            [Symbol("jz", "Jump short if zero (ZF=1)")]
            JZ = 0x74,

            [Symbol("jnz", "Jump short if not zero (ZF=0)")]
            JNZ = 0x75,

            [Symbol("jna", "Jump short if not above (CF=1 | ZF=1)")]
            JNA = 0x76,

            [Symbol("ja", "Jump short if above (CF=0 & ZF=0)")]
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
    }
}