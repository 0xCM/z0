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
        public readonly struct r16 : IRegOp16
        {    
            public Fixed16 Value  {get;}

            public RegisterKind Kind {get;}        

            [MethodImpl(Inline)]
            public r16(Fixed16 value, RegisterKind kind)
            {
                Value = value;
                Kind = kind;
            }
        }
    }
}