//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct TextParsers
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static PairParser<T> CreatePairParser<T>(string delimiter, TextParser<T> fx, bool clean = true)
            => new PairParser<T>(delimiter, fx, clean);

        [Op, Closures(Closure)]
        public static Outcome parse<T>(string input, PairParser<T> parser, out Pair<T> dst)
            => parser.Parse(input, out dst);

        public readonly struct PairParser<T> : IParseFunction<Pair<T>>
        {
            readonly TextParser<T> ItemParser;

            readonly string Delimiter;

            readonly bool SplitClean;

            [MethodImpl(Inline)]
            public PairParser(string delimiter, TextParser<T> fx, bool clean = true)
            {
                Delimiter = delimiter;
                ItemParser = fx;
                SplitClean = clean;
            }

            [MethodImpl(Inline)]
            public Outcome Parse(string src, out Pair<T> dst)
            {
                var result = Outcome.Success;
                dst = default;
                var components = text.split(src, Delimiter, SplitClean).View;
                var count = components.Length;
                if(count == 2)
                {
                    result = ItemParser.Parse(skip(components,0), out var left);
                    if(result)
                    {
                        result = ItemParser.Parse(skip(components,1), out var right);
                        if(result)
                            dst = (left,right);
                    }
                }
                else
                    result = (false,string.Format("The input text '{0}' splits into {1} component(s) instead of {2}", src, count, 2));

                return result;
            }
        }
    }
}