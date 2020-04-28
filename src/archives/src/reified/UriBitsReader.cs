//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Seed;
    using static Memories;

    public readonly struct UriBitsReader : IUriBitsReader
    {
        public static IUriBitsReader Service => default(UriBitsReader);
        
        /// <summary>
        /// Parses a row of identified hex text
        /// </summary>
        /// <param name="formatted">The formatted text</param>
        /// <param name="idsep">A character that partitions the identifier and the code</param>
        /// <param name="bytesep">A character that partitions the code bytes</param>
        Option<UriBits> Parse(string formatted)
        {
            try
            {
                var parser = HexParsers.Bytes;
                var uritext = formatted.TakeBefore(Chars.Space).Trim();
                var uri = OpUri.Parse(uritext);
                var bytes = formatted.TakeAfter(Chars.Space).SplitClean(HexSpecs.DataDelimiter).Select(parser.ParseByte).ToArray();
                return UriBits.Define(uri, bytes);                
            }
            catch(Exception e)
            {
                report(e);
                return default;
            }
        }

        public IEnumerable<UriBits> Read(FilePath src)
            => from line in src.ReadLines().Select(Parse)
                where line.IsSome()
                select line.Value;
    }
}