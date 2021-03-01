//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Represents an operand in the context of an instruction signature
    /// </summary>
    public readonly struct AsmSigOp
    {
        public AsmSigOpKind Kind {get;}

        [MethodImpl(Inline)]
        public AsmSigOp(AsmSigOpKind kind)
        {
            Kind = kind;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmSigOp(AsmSigOpKind src)
            => new AsmSigOp(src);
    }
}