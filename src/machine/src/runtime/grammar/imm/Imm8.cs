//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct Imm8 : IImm8<Imm8>
    {
        public byte Data {get;}

        [MethodImpl(Inline)]
        public static implicit operator Imm8(byte src)
            => new Imm8(src);

        [MethodImpl(Inline)]
        public Imm8(byte value)
        {
            Data = value;
        }

        public DataWidth Width 
            => DataWidth.W8;
    }
}