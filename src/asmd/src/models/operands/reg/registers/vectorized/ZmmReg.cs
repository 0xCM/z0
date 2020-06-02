//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct ZmmReg : IYmmRegOp<Fixed512>
    {
        public RegisterKind Kind {get;}
        
        [MethodImpl(Inline)]
        public ZmmReg(RegisterKind kind)
        {
            this.Kind = kind;
        }
    }
}