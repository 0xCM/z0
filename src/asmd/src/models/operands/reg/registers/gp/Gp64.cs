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

    public readonly struct GpReg64 : IRegOp64<Fixed64>
    {    
        public RegisterKind Kind {get;}
    }   

}