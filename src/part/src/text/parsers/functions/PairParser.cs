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

    partial struct ParseComposer
    {
        public readonly struct PairParser<T> : IParseFunction<Pair<T>>
        {
            readonly ParseFunction<T> ItemParser;

            readonly string Delimiter;

            readonly bool SplitClean;

            [MethodImpl(Inline)]
            public PairParser(string delimiter, ParseFunction<T> fx, bool clean = true)
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