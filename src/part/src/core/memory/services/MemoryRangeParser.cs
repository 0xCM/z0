//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct MemoryRangeParser
    {
        /// <summary>
        /// Attempts to parse an address segment in standard form, [start,end]
        /// </summary>
        /// <param name="src">The source text</param>
        public static Outcome parse(string src, out MemoryRange dst)
        {
            var option = parse(src);
            if(option)
            {
                dst = option.Value;
                return true;
            }
            else
            {
                dst = MemoryRange.Empty;
                return false;
            }
        }

        static Option<MemoryRange> parse(string src)
             => from i0 in src.FirstIndexOf(Chars.LBracket)
                from i1 in src.FirstIndexOf(Chars.RBracket)
                let inner = src.Substring(i0 + 1, i1 - i0 - 1)
                let parts = inner.Split(Chars.Comma).Trim()
                where parts.Length == 2
                let parser = HexScalarParser.Service
                from start in parser.Parse(parts[0]).ToOption()
                from end in parser.Parse(parts[1]).ToOption()
                select new MemoryRange(start, end);
    }
}