//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using K = ConditionCodes.ConditionKind;
    using E = ConditionCodes.Expressions;

    partial struct ConditionCodes
    {
        [SymSource(K.Jcc32Alt)]
        public enum Jcc32Alt : byte
        {
            [Symbol("jo", "Jump short if overflow", E.O)]
            JO = 0x80,

            [Symbol("jno", "Jump short if not overflow", E.NO)]
            JNO = 0x81,

            [Symbol("jnae", "Jump short if not above or equal", E.NAE)]
            JNAE = 0x82,

            [Symbol("jae", "Jump short if above or equal", E.AE)]
            JAE = 0x83,

            [Symbol("je", "Jump short if equal", E.E)]
            JE = 0x84,

            [Symbol("jne", "Jump short if not equal", E.NE)]
            JNE = 0x85,

            [Symbol("jbe", "Jump short if below or equal", E.BE)]
            JBE = 0x86,

            [Symbol("jnbe", "Jump short if not below or equal", E.NBE)]
            JNBE = 0x87,

            [Symbol("js", "Jump short if sign", E.S)]
            JS = 0x88,

            [Symbol("jns", "Jump short if not sign", E.NS)]
            JNS = 0x89,

            [Symbol("jp", "Jump short if parity", E.P)]
            JP = 0x8A,

            [Symbol("jnp", "Jump short if not parity", E.NP)]
            JNP = 0x8B,

            [Symbol("jnge", "Jump short if not greater or equal", E.NGE)]
            JNGE = 0x8C,

            [Symbol("jge", "Jump short if greater or equal", E.GE)]
            JGE = 0x8D,

            [Symbol("jle", "Jump short if less or equal", E.LE)]
            JLE = 0x8E,

            [Symbol("jg", "Jump short if greater", E.G)]
            JG = 0x8F
        }
    }
}