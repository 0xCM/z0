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
        public readonly struct imm64 : imm<imm64, W64, ulong>
        {
            public ulong Literal {get;}

            [MethodImpl(Inline)]
            public static implicit operator ulong(imm64 src)
                => src.Literal;

            [MethodImpl(Inline)]
            public static implicit operator imm64(ulong src)
                => new imm64(src);

            [MethodImpl(Inline)]
            public imm64(ulong src)
            {
                this.Literal = src;
            }
        
        }
    }
}