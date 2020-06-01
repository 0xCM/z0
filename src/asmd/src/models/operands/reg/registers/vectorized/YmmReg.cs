//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Registers;

    using K = RegisterKind;

    public readonly struct YmmReg : IYmmRegOp<Fixed256>
    {
        public RegisterKind Kind {get;}

        [MethodImpl(Inline)]
        public YmmReg(RegisterKind kind)
        {
            this.Kind = kind;
        }
    }
}