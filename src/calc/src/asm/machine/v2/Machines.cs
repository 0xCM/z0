//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static MemorySections;
    using static Asm.RegMachines;

    using SQ = SymbolicQuery;

    [ApiHost]
    public readonly partial struct Machines
    {
        [MethodImpl(Inline), Op]
        public static ByteMachine machine(N8 n, in Section buffer)
            => new ByteMachine(buffer);

        [MethodImpl(Inline), Op]
        public static Store8x64 regs(N8 n, W64 w)
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