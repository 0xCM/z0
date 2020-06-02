//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct GpReg64 : IRegOp64<Fixed64>
    {    
        [MethodImpl(Inline)]
        public GpReg64(RegisterKind kind)
        {
            this.Kind = kind;
        }

        public RegisterKind Kind {get;}
    }   

}