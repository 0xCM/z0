//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class AsmSigs
    {
        public readonly struct imm : IImmOpClass<imm>
        {
            public AsmSizeClass SizeClass {get;}

            [MethodImpl(Inline)]
            public imm(AsmSizeClass size)
            {
                SizeClass = size;
            }

            public AsmOpClass OpClass
                => AsmOpClass.Imm;

            [MethodImpl(Inline)]
            public static implicit operator AsmOperand(imm src)
                => new AsmOperand(src.OpClass, src.SizeClass);
        }

        public readonly struct imm8 : IImmOpClass<imm8>
        {
            public AsmOpClass OpClass
                => AsmOpClass.Imm;

            public AsmSizeClass SizeClass
                => AsmSizeClass.@byte;

            [MethodImpl(Inline)]
            public static implicit operator imm(imm8 src)
                => new imm(src.SizeClass);

            [MethodImpl(Inline)]
            public static implicit operator AsmOperand(imm8 src)
                => new AsmOperand(src.OpClass, src.SizeClass);
        }

        public readonly struct imm16 : IImmOpClass<imm16>
        {
            public AsmOpClass OpClass
                => AsmOpClass.Imm;

            public AsmSizeClass SizeClass
                => AsmSizeClass.word;

            [MethodImpl(Inline)]
            public static implicit operator imm(imm16 src)
                => new imm(src.SizeClass);

            [MethodImpl(Inline)]
            public static implicit operator AsmOperand(imm16 src)
                => new AsmOperand(src.OpClass, src.SizeClass);
        }

        public readonly struct imm32 : IImmOpClass<imm32>
        {
            public AsmOpClass OpClass
                => AsmOpClass.Imm;

            public AsmSizeClass SizeClass
                => AsmSizeClass.dword;

            [MethodImpl(Inline)]
            public static implicit operator imm(imm32 src)
                => new imm(src.SizeClass);

            [MethodImpl(Inline)]
            public static implicit operator AsmOperand(imm32 src)
                => new AsmOperand(src.OpClass, src.SizeClass);
        }

        public readonly struct imm64 : IImmOpClass<imm64>
        {
            public AsmOpClass OpClass
                => AsmOpClass.Imm;

            public AsmSizeClass SizeClass
                => AsmSizeClass.qword;

            [MethodImpl(Inline)]
            public static implicit operator imm(imm64 src)
                => new imm(src.SizeClass);

            [MethodImpl(Inline)]
            public static implicit operator AsmOperand(imm64 src)
                => new AsmOperand(src.OpClass, src.SizeClass);
        }
    }
}