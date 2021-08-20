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
        [SymSource(K.Jcc32)]
        public enum Jcc32 : byte
        {
            [Symbol("jo", "Jump short if overflow", E.O)]
            JO = 0x80,

            [Symbol("jno", "Jump short if not overflow", E.NO)]
            JNO = 0x81,

            [Symbol("jb", "Jump short if below", E.B)]
            JB = 0x82,

            [Symbol("jnb", "Jump short if not below", E.NB)]
            JNB = 0x83,

            [Symbol("jz", "Jump short if zero", E.Z)]
            JZ = 0x84,

            [Symbol("jnz", "Jump short if not zero", E.NZ)]
            JNZ = 0x85,

            [Symbol("jna", "Jump short if not above", E.NA)]
            JNA = 0x86,

            [Symbol("ja", "Jump short if above", E.A)]
            JA = 0x87,

            [Symbol("js", "Jump short if sign", E.S)]
            JS = 0x88,

            [Symbol("jns", "Jump short if not sign", E.NS)]
            JNS = 0x89,

            [Symbol("jpe", "Jump short if parity even", E.PE)]
            JPE = 0x8A,

            [Symbol("jpo", "Jump short if parity odd", E.PO)]
            JPO = 0x8B,

            [Symbol("jl", "Jump short if less", E.L)]
            JL = 0x8C,

            [Symbol("jnl", "Jump short if not less", E.NL)]
            JNL = 0x8D,

            [Symbol("jng", "Jump short if not greater", E.NG)]
            JNG = 0x8E,

            [Symbol("jnle", "Jump short if not less or equal", E.NLE)]
            JNLE = 0x8F,
        };
    }
}