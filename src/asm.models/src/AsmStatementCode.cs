//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmStatementCode : ITextual
    {
        public readonly asci64 Asm;

        [MethodImpl(Inline)]
        public static implicit operator AsmStatementCode(string src)
            => new AsmStatementCode(src);

        [MethodImpl(Inline)]
        public AsmStatementCode(in asci64 asm)
            => Asm = asm;

        public string Format()
            => Asm.Format();
    }
}