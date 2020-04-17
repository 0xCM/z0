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
        public readonly struct imm8 : imm<imm8, W8, byte>
        {
            public byte Literal {get;}

            [MethodImpl(Inline)]
            public static implicit operator byte(imm8 src)
                => src.Literal;

            [MethodImpl(Inline)]
            public static implicit operator imm8(byte src)
                => new imm8(src);

            [MethodImpl(Inline)]
            public imm8(byte src)
            {
                this.Literal = src;
            }
        
        }
    }
}