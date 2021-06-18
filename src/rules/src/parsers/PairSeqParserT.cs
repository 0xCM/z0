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

    public readonly struct PairSeqParser<T> : IParseFunction<Pair<T>[]>
    {
        readonly PairParser<T> PairFx;

        readonly SeqParser<string> SeqFx;

        [MethodImpl(Inline)]
        public PairSeqParser(PairParser<T> pFx, SeqParser<string> sFx)
        {
            PairFx = pFx;
            SeqFx = sFx;
        }

        [MethodImpl(Inline)]
        public Outcome Parse(string src, out Pair<T>[] dst)
        {
            dst = array<Pair<T>>();
            var result = SeqFx.Parse(src, out var terms);
            if(result)
            {
                var count = terms.Length;
                if(count != 0)
                {
                    dst = alloc<Pair<T>>(count);
                    ref var target = ref first(dst);
                    for(var i=0; i<count; i++)
                    {
                        ref readonly var term = ref skip(terms,i);
                        result = PairFx.Parse(term, out var pair);
                        if(result)
                            seek(target,i) = pair;
                        else
                            break;
                    }
                }
            }
            return result;
        }
    }
}