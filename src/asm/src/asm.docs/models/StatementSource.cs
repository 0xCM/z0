//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct AsmDocParts
    {
        public readonly struct StatementSource : ITextual
        {
            public TextBlock Asm {get;}

            [MethodImpl(Inline)]
            public StatementSource(string asm)
                => Asm = asm;

            [MethodImpl(Inline)]
            public string Format()
                => Asm;

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator StatementSource(string src)
                => new StatementSource(src);
        }
    }
}