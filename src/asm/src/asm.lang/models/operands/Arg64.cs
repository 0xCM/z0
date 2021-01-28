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
    /// Defines a 64-bit operand
    /// </summary>
    public readonly struct Arg64 : IAsmOperand<Arg64,W64,ulong>
    {

        public ulong Content {get;}

        public AsmOperandKind Kind {get;}

        [MethodImpl(Inline)]
        public Arg64(ulong value, AsmOperandKind kind)
        {
            Content = value;
            Kind = kind;
        }
    }
}