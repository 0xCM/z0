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
        public readonly struct r64 : IRegOp64
        {    
            public Fixed64 Value  {get;}

            public RegisterKind Kind {get;}
            
            [MethodImpl(Inline)]
            public r64(Fixed64 value, RegisterKind kind)
            {
                Value = value;
                Kind = kind;
            }
        }   
    }
}