//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static ParseFunctions;
    using static z;

    public readonly struct ParserHost<S,T> : ICanonical<S,T>, IParserHost
    {
        readonly ICanonical<S,T> Parser;

        [MethodImpl(Inline)]
        public ParserHost(IParseFunction parser)
            => Parser = (ICanonical<S,T>)parser;

        [MethodImpl(Inline)]
        public bool Parse(in S src, out T dst)
            => Parser.Parse(src, out dst);

        [MethodImpl(Inline)]
        bool IParserHost.Parse<S1,T1>(in S1 src, out T1 dst)
        {
            dst = default;
            ref readonly var s = ref @as<S1,S>(src);
            ref var t = ref @as<T1,T>(dst);
            return Parse(s, out t);
        }
    }
}