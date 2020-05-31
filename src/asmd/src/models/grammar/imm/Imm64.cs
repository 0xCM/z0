//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct Imm64 : IImm64<Imm64>
    {
        public ulong Data {get;}

        [MethodImpl(Inline)]
        public static implicit operator Imm64(ulong src)
            => new Imm64(src);

        [MethodImpl(Inline)]
        public Imm64(ulong value)
        {
            Data = value;
        }
        
        public DataWidth Width => DataWidth.W64;
    }
}