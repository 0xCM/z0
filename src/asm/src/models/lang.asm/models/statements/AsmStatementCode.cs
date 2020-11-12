//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct AsmStatementCode : ITextual
    {
        public readonly string Asm;

        [MethodImpl(Inline)]
        public static implicit operator AsmStatementCode(string src)
            => new AsmStatementCode(src);

        [MethodImpl(Inline)]
        public AsmStatementCode(string asm)
            => Asm = asm;

        [MethodImpl(Inline)]
        public string Format()
            => Asm;

        public override string ToString()
            => Format();
    }
}