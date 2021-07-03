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
            dst = array<T>();
            var components = text.split(src, Delimiter, SplitClean);
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