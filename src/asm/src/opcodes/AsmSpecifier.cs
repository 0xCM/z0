//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Captures an asm opcode together with an instruction string
    /// </summary>
    public readonly struct AsmSpecifier : ITextual
    {
        public readonly string Pattern;

        public readonly string Code;

        [MethodImpl(Inline)]
        public AsmSpecifier(string pattern, string opcode)
        {
            Pattern = pattern;
            Code = opcode.Replace("o32 ", EmptyString);
        }

        [MethodImpl(Inline)]
        public string Format()
            => String.Concat(Pattern, SpacePipe, Code);

        public override string ToString()
            => Format();
    }
}