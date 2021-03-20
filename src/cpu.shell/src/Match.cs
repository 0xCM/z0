//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly struct Match
    {
        [MethodImpl(Inline)]
        public static int test(SpanBlock128<byte> src, byte match)
        {
            var ones = gcpu.vones<byte>(w128);
            for(var i=0; i<src.BlockCount; i++)
            {
                var a = cpu.vload(src,i);
                var b = cpu.vbroadcast(w128, match);
                var c = cpu.veq(a,b);
                var d = cpu.vtestz(c,ones);
                if(!d)
                    return i;
            }

            return NotFound;
        }

        public static void test(SpanBlock128<byte> src, byte match, out Detail log)
        {
            log.Searched = src;
            log.Target = match;
            log.MatchingBlock = test(src,match);
            log.Found = log.MatchingBlock != NotFound;
        }

        public ref struct Detail
        {
            public SpanBlock128<byte> Searched;

            public byte Target;

            public bit Found;

            public int MatchingBlock;

        }
    }

}