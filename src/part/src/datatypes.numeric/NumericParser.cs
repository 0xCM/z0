//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static root;

    [ApiHost]
    public class NumericParser
    {
        /// <summary>
        /// Parses a transposition in canonical form (i j), if possible; otherwise returns the empty transposition
        /// </summary>
        /// <param name="src">The source text</param>
        public static ParseResult<Pair<T>> transposition<T>(string src)
            where T : unmanaged
        {
            var indices = src.RemoveAny(Chars.LParen, Chars.RParen).Trim().Split(Chars.Space);
            if(indices.Length != 2)
                return unparsed<Pair<T>>(src);

            var parser = Numeric.parser<T>();
            var result = Option.Try(() => Tuples.pair(parser.Parse(indices[0]).ValueOrDefault(), parser.Parse(indices[1]).ValueOrDefault()));
            if(result.IsSome())
                return parsed(src, result.Value());
            else
                return unparsed<Pair<T>>(src);
        }
    }
}
