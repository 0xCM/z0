//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial class AsmSigs
    {
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
    }
}