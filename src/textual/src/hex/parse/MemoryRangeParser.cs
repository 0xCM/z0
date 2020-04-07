//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    readonly struct MemoryRangeParser : IParser<MemoryRange>
    {        
        /// <summary>
        /// Attempts to parse an address segment in standard form, [start,end]
        /// </summary>
        /// <param name="src">The source text</param>
        public ParseResult<MemoryRange> Parse(string src)    
             => ParseOption(src).MapValueOrElse(x => ParseResult.Success(src,x), () => ParseResult.Fail<MemoryRange>(src));

        /// <summary>
        /// Attempts to parse an address segment in standard form, [start,end]
        /// </summary>
        /// <param name="src">The source text</param>
        static Option<MemoryRange> ParseOption(string src)    
             => from i0 in src.FirstIndexOf(text.lbracket()).ToOption()
                from i1 in src.FirstIndexOf(text.rbracket()).ToOption()
                let inner = src.Substring(i0 + 1, i1 - i0 - 1)
                let parts = inner.Split(text.comma()).Trim()
                where parts.Length == 2
                from start in HexParsers.Numeric.Parse(parts[0]).ToOption()
                from end in HexParsers.Numeric.Parse(parts[1]).ToOption()
                select MemoryRange.Define(start, end);
    }
}