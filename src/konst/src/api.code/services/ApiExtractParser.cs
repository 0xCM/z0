//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static root;

    public readonly struct ApiExtractParser
    {
        public static ParseResult<ApiExtractBlock> extracts(string src)
        {
            try
            {
                var parts = src.SplitClean(FieldDelimiter);
                var parser = HexParsers.bytes();
                if(parts.Length != 3)
                    return unparsed<ApiExtractBlock>(src, $"components = {parts.Length} != 3");

                var address = HexParsers.scalar().Parse(parts[(byte)ApiExtractField.Base]).ValueOrDefault();
                var uri = ApiUri.parse(parts[(byte)ApiExtractField.Uri].Trim()).ValueOrDefault();
                var bytes = parts[(byte)ApiExtractField.Encoded].SplitClean(HexFormatSpecs.DataDelimiter).Select(parser.Succeed);
                return parsed(src, new ApiExtractBlock(address, uri, bytes));
            }
            catch(Exception e)
            {
                return unparsed<ApiExtractBlock>(src,e);
            }
        }
    }
}