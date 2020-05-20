//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct Imm16 : IImm16<Imm16>
    {
        public ushort Value {get;}

        [MethodImpl(Inline)]
        public static implicit operator Imm16(ushort src)
            => new Imm16(src);

        [MethodImpl(Inline)]
        public Imm16(ushort value)
        {
            Value = value;
        }

        public DataWidth Width 
            => DataWidth.W16;
    }
}