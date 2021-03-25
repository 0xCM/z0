//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmSourceCode : ITextual
    {
        public TextBlock Asm {get;}

        [MethodImpl(Inline)]
        public AsmSourceCode(string asm)
            => Asm = asm;

        [MethodImpl(Inline)]
        public string Format()
            => Asm;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator AsmSourceCode(string src)
            => new AsmSourceCode(src);
    }
}