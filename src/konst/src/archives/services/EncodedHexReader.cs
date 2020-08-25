//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    public readonly struct EncodedHexReader : IEncodedHexReader<EncodedHexReader,IdentifiedCode>
    {
        public static IEncodedHexReader Service => default(EncodedHexReader);

        public IdentifiedCode[] Read(FilePath src)
            => read(src);

        static IdentifiedCode[] read(FilePath src)
            => from line in src.ReadLines().Select(Parse)
                where line.IsSome()
                select line.Value;

        /// <summary>
        /// Parses a row of identified hex text
        /// </summary>
        /// <param name="formatted">The formatted text</param>
        static Option<IdentifiedCode> Parse(string formatted)
        {
            try
            {
                var parser = Parsers.hex(true);
                var uritext = formatted.TakeBefore(Chars.Space).Trim();
                var uri = OpUriParser.Service.Parse(uritext);
                var bytes = formatted.TakeAfter(Chars.Space).SplitClean(HexFormatSpecs.DataDelimiter).Select(parser.Succeed);
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
    }
}