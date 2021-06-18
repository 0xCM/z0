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

        [Op, Closures(Closure)]
        public static Outcome parse(string input, CharSeqParser parser, out Index<char[]> dst)
            => parser.Parse(input, out dst);

        [Op]
        public static ParseFunctions Collect(params IParseFunction[] src)
            => new ParseFunctions(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static PairSeqParser<T> CreatePairSeqParser<T>(PairParser<T> pFx, SeqParser<string> sFx)
            => new PairSeqParser<T>(pFx,sFx);

        [Op, Closures(Closure)]
        public static Outcome parse<T>(string input, PairSeqParser<T> parser, out Pair<T>[] dst)
            => parser.Parse(input, out dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static FenceParser CreateFenceParser(Fence<char> fence)
            => new FenceParser(fence);

        [Op, Closures(Closure)]
        public static Outcome parse(string input, FenceParser parser, out string dst)
            => parser.Parse(input, out dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static PairParser<T> CreatePairParser<T>(string delimiter, ParseFunction<T> fx, bool clean = true)
            => new PairParser<T>(delimiter, fx, clean);

        [Op, Closures(Closure)]
        public static Outcome parse<T>(string input, PairParser<T> parser, out Pair<T> dst)
            => parser.Parse(input, out dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SeqParser<T> CreateSeqParser<T>(string delimiter, ParseFunction<T> fx, bool clean = true)
            => new SeqParser<T>(delimiter, fx, clean);

        [Op, Closures(Closure)]
        public static Outcome parse<T>(string input, SeqParser<T> parser, out T[] dst)
            => parser.Parse(input, out dst);

        public static MsgPattern<Fence<char>,string> FenceNotFound => "No content fenced with {0} exists int the input text '{1}'";

        public static string EmptyInput => "The input was empty";
    }
}