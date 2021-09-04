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
    }
}