//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;


    partial class AsmMetamodels
    {
        public readonly struct imm : IImmOp<imm>
        {
            public AsmSizeKind Size {get;}

            [MethodImpl(Inline)]
            public imm(AsmSizeKind size)
            {
                Size = size;
            }

            public AsmOpClass OpClass => AsmOpClass.Imm;

            [MethodImpl(Inline)]
            public static implicit operator operand(imm src)
                => new operand(src.OpClass, src.Size);
        }

        public readonly struct imm8 : IImmOp<imm8>
        {
            public AsmOpClass OpClass => AsmOpClass.Imm;

            public AsmSizeKind Size => AsmSizeKind.@byte;

            [MethodImpl(Inline)]
            public static implicit operator imm(imm8 src)
                => new imm(src.Size);

            [MethodImpl(Inline)]
            public static implicit operator operand(imm8 src)
                => new operand(src.OpClass, src.Size);
        }

        public readonly struct imm16 : IImmOp<imm16>
        {
            public AsmOpClass OpClass => AsmOpClass.Imm;

            public AsmSizeKind Size => AsmSizeKind.word;

            [MethodImpl(Inline)]
            public static implicit operator imm(imm16 src)
                => new imm(src.Size);

            [MethodImpl(Inline)]
            public static implicit operator operand(imm16 src)
                => new operand(src.OpClass, src.Size);
        }

        public readonly struct imm32 : IImmOp<imm32>
        {
            public AsmOpClass OpClass => AsmOpClass.Imm;

            public AsmSizeKind Size => AsmSizeKind.dword;

            [MethodImpl(Inline)]
            public static implicit operator imm(imm32 src)
                => new imm(src.Size);

            [MethodImpl(Inline)]
            public static implicit operator operand(imm32 src)
                => new operand(src.OpClass, src.Size);
        }

        public readonly struct imm64 : IImmOp<imm64>
        {
            public AsmOpClass OpClass => AsmOpClass.Imm;

            public AsmSizeKind Size => AsmSizeKind.qword;

            [MethodImpl(Inline)]
            public static implicit operator imm(imm64 src)
                => new imm(src.Size);

            [MethodImpl(Inline)]
            public static implicit operator operand(imm64 src)
                => new operand(src.OpClass, src.Size);

        }
    }
}