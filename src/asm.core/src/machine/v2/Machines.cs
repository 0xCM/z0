//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Root;
    using static core;
    using static MemorySections;

    using SQ = SymbolicQuery;

    [ApiHost]
    public readonly partial struct Machines
    {
        [MethodImpl(Inline), Op]
        public static ByteMachine machine(N8 n, in SectionEntry buffer)
            => new ByteMachine(buffer);

        [MethodImpl(Inline), Op]
        public static Regs8x64 regs(N8 n, W64 w)
            => default;

        public abstract class CharParser : Machine<char>
        {
            protected bit HexDigit(char src)
                => SQ.hexdigit(src);

            protected bit Whitespace(char src)
                => SQ.whitespace(src);

            protected bit LineTerm(char src)
                => SQ.whitespace(src);
        }
    }
}