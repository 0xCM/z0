//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Models
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    public readonly struct Imm64 : IImm64<Imm64>
    {
        public ulong Value {get;}

        [MethodImpl(Inline)]
        public static implicit operator Imm64(ulong src)
            => new Imm64(src);

        [MethodImpl(Inline)]
        public Imm64(ulong value)
        {
            Value = value;
        }
        
        public OperandSize Width => OperandSize.W64;
    }

}