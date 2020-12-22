//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;

    public readonly struct ApiHexParser : ITextParser<ApiCodeBlock>
    {
        /// <summary>
        /// Parses a row of identified hex text
        /// </summary>
        /// <param name="src">The formatted text</param>
        ParseResult<ApiCodeBlock> ITextParser<ApiCodeBlock>.Parse(string src)
            => extracts(src);

        public static ParseResult<ApiCodeBlock> extracts(string src)
        {
            try
            {
                var parts = src.SplitClean(FieldDelimiter);
                var parser = Parsers.hex(true);
                if(parts.Length != 3)
                    return unparsed<ApiCodeBlock>(src, $"components = {parts.Length} != 3");

                var address = Parsers.hex().Parse(parts[(byte)ApiCodeField.Base]).ValueOrDefault();
                var uri = ApiUri.parse(parts[(byte)ApiCodeField.Uri].Trim()).ValueOrDefault();
                var bytes = parts[(byte)ApiCodeField.Encoded].SplitClean(HexFormatSpecs.DataDelimiter).Select(parser.Succeed);
                return parsed(src, new ApiCodeBlock(address, uri, bytes, CliSig.Empty));
            }
            catch(Exception e)
            {
                return unparsed<ApiCodeBlock>(src,e);
            }
        }
    }
}