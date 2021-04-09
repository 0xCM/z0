//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmOps
    {
        public readonly struct imm64 : IImmOp64<Imm64>
        {
            public Imm64 Content {get;}

            [MethodImpl(Inline)]
            public imm64(ulong value)
                => Content = value;

            [MethodImpl(Inline)]
            public static implicit operator imm64(ulong src)
                => new imm64(src);

            [MethodImpl(Inline)]
            public static implicit operator imm64(Imm64 src)
                => new imm64(src);
        }
    }
}