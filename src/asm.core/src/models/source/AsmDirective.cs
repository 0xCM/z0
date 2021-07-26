//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmDirective
    {
        public AsmDirectiveKind Kind {get;}

        public Index<string> Operands {get;}

        [MethodImpl(Inline)]
        public AsmDirective(AsmDirectiveKind kind, string[] operands)
        {
            Kind = kind;
            Operands = operands;
        }
    }

    public enum AsmDirectiveKind : byte
    {

    }
}