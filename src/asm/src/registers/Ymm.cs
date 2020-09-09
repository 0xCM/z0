//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Ymm : IYmmOperand
    {
        public Cell256 Content {get;}

        public RegisterKind Kind {get;}

        [MethodImpl(Inline)]
        public Ymm(Cell256 value, RegisterKind kind)
        {
            Content = value;
            Kind = kind;
        }
    }

}