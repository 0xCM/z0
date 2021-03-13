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
    public readonly struct AsmSigOperand
    {
        public Identifier Name {get;}

        public AsmSigOpKind Kind {get;}

        [MethodImpl(Inline)]
        public AsmSigOperand(Identifier name, AsmSigOpKind kind)
        {
            Name  = name;
            Kind = kind;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmSigOperand((string name, AsmSigOpKind kind) src)
            => new AsmSigOperand(src.name, src.kind);
    }
}