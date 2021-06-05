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
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SeqParser<T> CreateSeqParser<T>(string delimiter, ParseFunction<T> fx, bool clean = true)
            => new SeqParser<T>(delimiter, fx, clean);

        [Op, Closures(Closure)]
        public static Outcome parse<T>(string input, SeqParser<T> parser, out T[] dst)
            => parser.Parse(input, out dst);

        public readonly struct SeqParser<T> : IParseFunction<T[]>
        {
            readonly ParseFunction<T> TermParser;

            readonly string Delimiter;

            readonly bool SplitClean;

            [MethodImpl(Inline)]
            public SeqParser(string delimiter, ParseFunction<T> tp, bool clean = true)
            {
                Delimiter = delimiter;
                TermParser = tp;
                SplitClean = clean;
            }

            [MethodImpl(Inline)]
            public Outcome Parse(string src, out T[] dst)
            {
                dst = sys.empty<T>();
                var components = text.split(src, Delimiter, SplitClean).View;
                var count = components.Length;
                var result = Outcome.Success;
                if(count != 0)
                {
                    dst = alloc<T>(count);
                    ref var target = ref first(dst);
                    for(var i=0; i<count; i++)
                    {
                        ref readonly var component = ref skip(components,i);
                        result = TermParser.Parse(component, out var term);
                        if(result)
                            seek(target,i) = term;
                        else
                            break;
                    }
                }
                return result;
            }
        }
    }
}