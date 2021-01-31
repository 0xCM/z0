//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static AsmSigOperandKind;

    using K = AsmSigOperandKind;

    public readonly partial struct AsmSigOperands
    {
        public static AsmSigOperand AL() => K.AL;

        public static AsmSigOperand AX() => K.AX;

        public static AsmSigOperand EAX() => K.EAX;

        public static AsmSigOperand RAX() => K.RAX;

        public static AsmSigOperand imm8() => K.Imm8 | ImmClass;

        public static AsmSigOperand imm16() => K.Imm16 | ImmClass;

        public static AsmSigOperand imm32() => K.Imm32 | ImmClass;

        public static AsmSigOperand imm64() => K.Imm64 | ImmClass;

        public static AsmSigOperand rm8() => K.Rm8 | RmClass;

        public static AsmSigOperand rm16() => K.Rm16 | RmClass;

        public static AsmSigOperand rm32() => K.Rm32 | RmClass;

        public static AsmSigOperand rm64() => K.Rm64 | RmClass;

        public static AsmSigOperand m8() => K.M8;

        public static AsmSigOperand m16() => K.M16;

        public static AsmSigOperand m32() => K.M32;

        public static AsmSigOperand m64() => K.M64;

        public static AsmSigOperand m128() => K.M128;

        public static AsmSigOperand m() => K.M;

        public static AsmSigOperand r8() => K.R8;

        public static AsmSigOperand r16() => K.R16;

        public static AsmSigOperand r32() => K.R32;

        public static AsmSigOperand r64() => K.R64;

        public static AsmSigOperand xmm1() => K.Xmm1;

        public static AsmSigOperand xmm2() => K.Xmm2;

        public static AsmSigOperand xmm3() => K.Xmm3;

        public static AsmSigOperand ymm1() => K.Ymm1;

        public static AsmSigOperand ymm2() => K.Ymm2;

        public static AsmSigOperand ymm3() => K.Ymm3;
    }
}