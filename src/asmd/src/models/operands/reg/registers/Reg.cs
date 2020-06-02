//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct Reg : IRegOp
    {
        public DataWidth Width {get;}

        public RegisterKind Kind {get;}

        public byte RegisterIndex 
            => (byte)Kind;

        [MethodImpl(Inline)]
        public Reg(RegisterKind kind, DataWidth width)
        {
            Kind = kind;
            Width = width;
        }
    }
}