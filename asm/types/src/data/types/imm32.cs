//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Seed;
    using static AsmSpecs;

    partial class AsmTypes
    {
        public readonly struct imm32 : imm<imm32, W32, uint>
        {
            public uint Literal {get;}

            [MethodImpl(Inline)]
            public static implicit operator uint(imm32 src)
                => src.Literal;

            [MethodImpl(Inline)]
            public static implicit operator imm32(uint src)
                => new imm32(src);

            [MethodImpl(Inline)]
            public imm32(uint src)
            {
                this.Literal = src;
            }
        
        }
    }
}