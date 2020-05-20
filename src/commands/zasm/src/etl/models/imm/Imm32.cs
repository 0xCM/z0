//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct Imm32 : IImm32<Imm32>
    {
        public uint Value {get;}

        [MethodImpl(Inline)]
        public static implicit operator Imm32(uint src)
            => new Imm32(src);

        [MethodImpl(Inline)]
        public Imm32(uint value)
        {
            Value = value;
        }

        public DataWidth Width => DataWidth.W32;
    }
}