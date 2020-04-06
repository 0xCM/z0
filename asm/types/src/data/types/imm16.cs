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
        public readonly struct imm16 : imm<imm16, W16, ushort>
        {
            public ushort Literal {get;}

            [MethodImpl(Inline)]
            public static implicit operator ushort(imm16 src)
                => src.Literal;

            [MethodImpl(Inline)]
            public static implicit operator imm16(ushort src)
                => new imm16(src);

            [MethodImpl(Inline)]
            public imm16(ushort src)
            {
                this.Literal = src;
            }
        
        }
    }
}