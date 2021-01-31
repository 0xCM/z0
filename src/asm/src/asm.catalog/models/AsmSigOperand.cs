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
        public AsmSigOperandId Kind {get;}

        [MethodImpl(Inline)]
        public AsmSigOperand(AsmSigOperandId kind)
        {
            Kind = kind;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmSigOperand(AsmSigOperandId src)
            => new AsmSigOperand(src);
    }
}