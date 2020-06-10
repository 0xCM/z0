//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Regs
    {
        public readonly struct ymm : IYmmRegOp
        {
            public Fixed256 Value {get;}
            public RegisterKind Kind {get;}

            [MethodImpl(Inline)]
            public ymm(Fixed256 value, RegisterKind kind)
            {
                Value = value;
                Kind = kind;
            }
                
        }
    }
}