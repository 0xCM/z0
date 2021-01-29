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
    /// Defines a 256-bit operand
    /// </summary>
    public readonly struct Arg256: IAsmOperand<Arg256,W256,Cell256>
    {
        public Cell256 Content {get;}

        public AsmOperandClass Kind {get;}

        [MethodImpl(Inline)]
        public Arg256(Cell256 value, SignKind sign, AsmOperandClass kind)
        {
            Content = value;
            Kind = kind;
        }
    }
}