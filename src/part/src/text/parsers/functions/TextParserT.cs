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
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static TextParser<T> CreateTextParser<T>(ParseFunction<T> fx)
            => new TextParser<T>(fx);

        [Op, Closures(Closure)]
        public static Outcome parse<T>(string input, TextParser<T> parser, out T dst)
            => parser.Parse(input, out dst);

        public readonly struct TextParser<T> : IParseFunction<T>
        {
            readonly ParseFunction<T> F;

            [MethodImpl(Inline)]
            internal TextParser(ParseFunction<T> f)
                => F = f;

            [MethodImpl(Inline)]
            public Outcome Parse(string src, out T dst)
                => F(src, out dst);
        }
    }
}