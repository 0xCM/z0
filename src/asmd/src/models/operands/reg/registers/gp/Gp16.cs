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

    public readonly struct GpReg16 : IRegOp16<Fixed16>
    {    
        public RegisterKind Kind {get;}        
    }
}