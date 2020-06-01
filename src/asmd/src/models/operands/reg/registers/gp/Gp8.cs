//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;
    using static Registers;

    public readonly struct GpReg8 : IRegOp8<Fixed8>
    {    
        [MethodImpl(Inline)]
        public GpReg8(RegisterKind src)
        {
            this.Kind = src;
        }
        
        public RegisterKind Kind {get;}        
    }
}