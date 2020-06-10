//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct imm32 : IImmOp32<imm32>
    {
        public Fixed32 Value {get;}

        [MethodImpl(Inline)]
        public static implicit operator imm32(uint src)
            => new imm32(src);

        [MethodImpl(Inline)]
        public imm32(Fixed32 value)
        {
            Value = value;
        }

        public DataWidth Width 
            => DataWidth.W32;
    } 
}