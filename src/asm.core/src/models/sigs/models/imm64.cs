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