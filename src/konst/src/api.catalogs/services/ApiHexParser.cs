//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ApiHexParser
    {
        [Op]
        public static bool parse(string src, out ApiHexRow dst)
        {
            dst = new ApiHexRow();
            try
            {
                if(text.empty(src))
                {
                    term.error("No text!");
                    return false;
                }

                var fields = text.slice(src,1).SplitClean(FieldDelimiter);
                if(fields.Length !=  (uint)ApiHexRowSpec.FieldCount)
                {
                    term.error($"Found {fields.Length} but {ApiHexRowSpec.FieldCount} are required");
                    return false;
                }

                var index = 0;
                dst.Seq = Numeric.parse<int>(fields[index++]).ValueOrDefault();
                dst.SourceSeq = Numeric.parse<int>(fields[index++]).ValueOrDefault();
                dst.Address = MemoryAddressParser.succeed(fields[index++]);
                dst.Length = Numeric.parse<int>(fields[index++]).ValueOrDefault();
                dst.TermCode = Enums.parse(fields[index++], ExtractTermCode.None);
                dst.Uri = ApiUri.parse(fields[index++]).Require();
                dst.Data = new CodeBlock(dst.Address, HexParsers.bytes().ParseData(fields[index++], sys.empty<byte>()));
                return true;
            }
            catch(Exception e)
            {
                term.error(e);
                return false;
            }
        }
    }
}