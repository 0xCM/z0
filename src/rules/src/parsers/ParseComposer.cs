//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Rules;

    [ApiHost]
    public readonly partial struct ParseComposer
    {
        const NumericKind Closure = AllNumeric;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CharSeqParser CreateCharSeqParser(char delimiter, bool skipWs = true)
            => new CharSeqParser(delimiter ,skipWs);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static PairSeqParser<T> CreatePairSeqParser<T>(PairParser<T> pFx, SeqParser<string> sFx)
            => new PairSeqParser<T>(pFx,sFx);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static PairParser<T> CreatePairParser<T>(string delimiter, ParseFunction<T> fx, bool clean = true)
            => new PairParser<T>(delimiter, fx, clean);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SeqParser<T> CreateSeqParser<T>(string delimiter, ParseFunction<T> fx, bool clean = true)
            => new SeqParser<T>(delimiter, fx, clean);
    }
}