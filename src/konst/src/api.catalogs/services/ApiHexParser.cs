//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static root;

    public readonly struct ApiHexParser
    {
        public static ParseResult<ApiCodeBlock> extracts(string src)
        {
            try
            {
                var parts = src.SplitClean(FieldDelimiter);
                var parser = HexParsers.bytes();
                if(parts.Length != 3)
                    return unparsed<ApiCodeBlock>(src, $"components = {parts.Length} != 3");

                var address = HexParsers.scalar().Parse(parts[(byte)ApiCodeField.Base]).ValueOrDefault();
                var uri = ApiUri.parse(parts[(byte)ApiCodeField.Uri].Trim()).ValueOrDefault();
                var bytes = parts[(byte)ApiCodeField.Encoded].SplitClean(HexFormatSpecs.DataDelimiter).Select(parser.Succeed);
                return parsed(src, new ApiCodeBlock(address, uri, bytes));
            }
            catch(Exception e)
            {
                return unparsed<ApiCodeBlock>(src,e);
            }
        }
    }
}