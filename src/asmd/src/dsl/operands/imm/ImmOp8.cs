//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct imm8 : IImmOp8<imm8>
    {
        public Fixed8 Value {get;}

        [MethodImpl(Inline)]
        public static implicit operator imm8(byte src)
            => new imm8(src);

        [MethodImpl(Inline)]
        public imm8(Fixed8 value)
        {
            Value = value;
        }

        public DataWidth Width 
            => DataWidth.W8;
    }
}