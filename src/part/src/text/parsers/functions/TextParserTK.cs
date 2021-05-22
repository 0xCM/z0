//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct TextParsers
    {
        [MethodImpl(Inline)]
        public static TextParser<T,K> CreateTextParser<T,K>(ParseFunction<T> fx, K kind)
            where K : unmanaged
                => new TextParser<T,K>(fx,kind);

        public static Outcome parse<T,K>(string input, TextParser<T,K> parser, out T dst)
            where K : unmanaged
                => parser.Parse(input, out dst);

        public readonly struct TextParser<T,K> : IParseFunction<T,K>
            where K : unmanaged
        {
            readonly ParseFunction<T> F;

            public K Kind {get;}

            [MethodImpl(Inline)]
            internal TextParser(ParseFunction<T> f, K kind)
            {
                F = f;
                Kind = kind;
            }

            [MethodImpl(Inline)]
            public Outcome Parse(string src, out T dst)
                => F(src, out dst);
        }

    }
}