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

    public readonly struct CharSeqParser : IParseFunction<Index<char[]>>
    {
        readonly char Delimiter;

        readonly bool SkipWs;

        [MethodImpl(Inline)]
        public CharSeqParser(char delimiter, bool skipWs = true)
        {
            Delimiter = delimiter;
            SkipWs = skipWs;
        }

        public Outcome Parse(string src, out Index<char[]> dst)
        {
            dst = Index<char[]>.Empty;
            var result = Outcome.Success;
            var input = span(src);
            var count = text.length(src);
            var counter = 0u;
            var buckets = list<char[]>();
            var bucket = list<char>();
            if(count != 0)
            {
                var buffer = span<char>(count);
                for(var i=0; i<count; i++)
                {
                    ref readonly var c = ref skip(input,i);
                    if(SkipWs && SymbolicQuery.whitespace(c))
                        continue;

                    if(c == Delimiter)
                    {
                        if(bucket.Count != 0)
                        {
                            buckets.Add(bucket.ToArray());
                            bucket.Clear();
                        }

                        continue;
                    }

                    bucket.Add(c);
                }

                if(bucket.Count != 0)
                    buckets.Add(bucket.ToArray());

                if(buckets.Count != 0)
                    dst = buckets.ToArray();
            }

            return result;
        }
    }
}