//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using SQ = SymbolicQuery;

    public readonly partial struct Machines
    {
        public abstract class Machine<T>
        {
            [MethodImpl(Inline)]
            public uint Accept(ReadOnlySpan<T> src)
            {
                var accepted = bit.On;
                var count = src.Length;
                var i=0u;
                while(accepted && i <count)
                {
                    ref readonly var token = ref skip(src,i);
                    accepted = Accept(token);
                    if(accepted)
                        i++;
                }
                return i;
            }

            public abstract bit Accept(T src);

            public abstract bit Finished();

            protected abstract void Reset();
        }

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