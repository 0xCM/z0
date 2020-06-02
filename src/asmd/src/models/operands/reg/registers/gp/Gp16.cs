//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct GpReg16 : IRegOp16<Fixed16>
    {    
        [MethodImpl(Inline)]
        public GpReg16(RegisterKind kind)
        {
            this.Kind = kind;
        }

        public RegisterKind Kind {get;}        
    }
}