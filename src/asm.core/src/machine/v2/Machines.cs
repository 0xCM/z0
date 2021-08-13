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
        [Op]
        public static uint jcc8(Conditions src, Span<Jcc8Conditions> dst)
        {
            var jcc = src.JccCodes(w8, n0);
            var jccAlt = src.JccCodes(w8, n1);
            var count = jcc.Length;
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var code = ref skip(jcc,i);
                ref readonly var codeAlt = ref skip(jccAlt,i);
                ref readonly var name = ref src.Name(code);
                ref readonly var nameAlt = ref src.Name(codeAlt);
                ref readonly var info = ref src.Describe(code);
                ref readonly var infoAlt = ref src.Describe(codeAlt);
                ref var target = ref seek(dst,counter++);
                target.Primary = AsmEncoder.jcc(code, name, AsmSizeKind.@byte);
                target.Alt = AsmEncoder.jcc(codeAlt, nameAlt, AsmSizeKind.@byte);
                target.PrimaryInfo = info.Text;
                target.AltInfo = infoAlt.Text;
           }
            return (uint)count;
        }

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