//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct ConditionCodes
    {
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

            [Symbol("jna", "Jump near if not above (CF=1 | ZF=1)")]
            JNA = 0x86,

            [Symbol("ja", "Jump near if above (CF=0 & ZF=0)")]
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

            [Symbol("jng", "Jump near if not greater (ZF=1 | SF!=OF)")]
            JNG = 0x8E,

            [Symbol("jnle", "Jump near if not less or equal (ZF=0 & SF=OF)")]
            JNLE = 0x8F,
        };
    }
}