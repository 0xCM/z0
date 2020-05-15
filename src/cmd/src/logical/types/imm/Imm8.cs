//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Logical
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    public readonly struct Imm8 : IImm8<Imm8>
    {
        public byte Value {get;}

        [MethodImpl(Inline)]
        public static implicit operator Imm8(byte src)
            => new Imm8(src);

        [MethodImpl(Inline)]
        public Imm8(byte value)
        {
            Value = value;
        }

        public OperandSize Width 
            => OperandSize.W8;
    }
}