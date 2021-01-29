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
    /// Defines a 32-bit operand
    /// </summary>
    public readonly struct Arg32 : IAsmOperand<Arg32,W32,uint>
    {
        public uint Content {get;}

        public AsmOperandClass Kind {get;}

        [MethodImpl(Inline)]
        public Arg32(uint value, SignKind sign, AsmOperandClass kind)
        {
            Content = value;
            Kind = kind;
        }
    }
}