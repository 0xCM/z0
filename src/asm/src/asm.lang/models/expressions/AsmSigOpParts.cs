//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static AsmSigOpKind;

    using K = AsmSigOpKind;

    public readonly partial struct AsmSigOpParts
    {
        public static AsmSigOp AL() => K.AL;

        public static AsmSigOp AX() => K.AX;

        public static AsmSigOp EAX() => K.EAX;

        public static AsmSigOp RAX() => K.RAX;

        public static AsmSigOp imm8() => K.Imm8 | ImmClass;

        public static AsmSigOp imm16() => K.Imm16 | ImmClass;

        public static AsmSigOp imm32() => K.Imm32 | ImmClass;

        public static AsmSigOp imm64() => K.Imm64 | ImmClass;

        public static AsmSigOp rm8() => K.Rm8 | RmClass;

        public static AsmSigOp rm16() => K.Rm16 | RmClass;

        public static AsmSigOp rm32() => K.Rm32 | RmClass;

        public static AsmSigOp rm64() => K.Rm64 | RmClass;

        public static AsmSigOp m8() => K.M8;

        public static AsmSigOp m16() => K.M16;

        public static AsmSigOp m32() => K.M32;

        public static AsmSigOp m64() => K.M64;

        public static AsmSigOp m128() => K.M128;

        public static AsmSigOp m() => K.M;

        public static AsmSigOp r8() => K.R8;

        public static AsmSigOp r16() => K.R16;

        public static AsmSigOp r32() => K.R32;

        public static AsmSigOp r64() => K.R64;

        public static AsmSigOp xmm1() => K.Xmm1;

        public static AsmSigOp xmm2() => K.Xmm2;

        public static AsmSigOp xmm3() => K.Xmm3;

        public static AsmSigOp ymm1() => K.Ymm1;

        public static AsmSigOp ymm2() => K.Ymm2;

        public static AsmSigOp ymm3() => K.Ymm3;
    }
}