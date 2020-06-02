//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct GpReg8 : IRegOp8<Fixed8>
    {    
        public RegisterKind Kind {get;}        
        
        [MethodImpl(Inline)]
        public GpReg8(RegisterKind src)
        {
            this.Kind = src;
        }    
    }
}