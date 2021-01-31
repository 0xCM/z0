//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmSigOperand
    {
        public AsmSigOperandKind Kind {get;}

        [MethodImpl(Inline)]
        public AsmSigOperand(AsmSigOperandKind kind)
        {
            Kind = kind;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmSigOperand(AsmSigOperandKind src)
            => new AsmSigOperand(src);
    }
}