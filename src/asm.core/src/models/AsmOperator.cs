//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmOperator
    {
        public AsmOperatorKind Kind {get;}

        [MethodImpl(Inline)]
        public AsmOperator(AsmOperatorKind kind)
        {
            Kind = kind;
        }
    }

    public enum AsmOperatorKind : byte
    {
        None  = 0,

        [Symbol("+")]
        Add,

        [Symbol("-")]
        Sub
    }
}