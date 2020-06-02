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

    public readonly struct GpReg32 : IRegOp32<Fixed32>
    {    
        [MethodImpl(Inline)]
        public GpReg32(RegisterKind kind)
        {
            this.Kind = kind;
        }

        public RegisterKind Kind {get;}

    }
}