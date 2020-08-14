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

    public readonly struct EncodedHexReader : IEncodedHexReader
    {
        public static IEncodedHexReader Service => default(EncodedHexReader);
        
        /// <summary>
        /// Parses a row of identified hex text
        /// </summary>
        /// <param name="formatted">The formatted text</param>
        /// <param name="idsep">A character that partitions the identifier and the code</param>
        /// <param name="bytesep">A character that partitions the code bytes</param>
        Option<IdentifiedCode> Parse(string formatted)
        {
            try
            {
                var parser = Parsers.hex(true);
                var uritext = formatted.TakeBefore(Chars.Space).Trim();
                var uri = OpUriParser.Service.Parse(uritext);
                var bytes = formatted.TakeAfter(Chars.Space).SplitClean(HexSpecs.DataDelimiter).Select(parser.Succeed);
                if(uri)
                    return new IdentifiedCode(MemoryAddress.Empty, uri.Value, bytes);
                else
                    return Option.none<IdentifiedCode>();
                         
            }
            catch(Exception e)
            {
                term.error(e);
                return default;
            }
        }

        public IEnumerable<IdentifiedCode> Read(FilePath src)
            => from line in src.ReadLines().Select(Parse)
                where line.IsSome()
                select line.Value;
    }
}