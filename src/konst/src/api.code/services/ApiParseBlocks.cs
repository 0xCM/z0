//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.ApiParseBlocks, true)]
    public readonly struct ApiParseBlocks
    {
        [Op]
        public static ParseResult<ApiHexRow[]> load(FS.FilePath src)
        {
            var attempts = src.ReadLines().Skip(1).Select(row);
            var failed = attempts.Where(r => !r.Succeeded);
            var success = attempts.Where(r => r.Succeeded).Select(r => r.Value);
            if(failed.Length != 0 && success.Length == 0)
                return ParseResult.Fail<ApiHexRow[]>(src.Name, failed[0].Message);
            else
                return ParseResult.Success<ApiHexRow[]>(src.Name, success);
        }

        [Op]
        public static ApiHexRow[] create(ApiHostUri host, ApiMemberCode[] members)
        {
            var count = members.Length;
            var buffer = alloc<ApiHexRow>(count);
            var dst = span(buffer);
            ref readonly var src = ref first(members);
            for(var i=0u; i<count; i++)
                seek(dst,i) = record(skip(src,i), i);
            return buffer;
        }

        [MethodImpl(Inline)]
        public static ApiHexRow record(in ApiMemberCode src, uint seq)
        {
            var dst = new ApiHexRow();
            dst.Seq = (int)seq;
            dst.SourceSeq = (int)src.Sequence;
            dst.Address = src.Address;
            dst.Length = src.Encoded.Length;
            dst.TermCode = src.TermCode;
            dst.Uri = src.OpUri;
            dst.ApiSig = CliSigs.resolve(src.Method);
            dst.Data = src.Encoded;
            return dst;
        }


        [MethodImpl(Inline), Op]
        public static Option<FS.FilePath> save(ApiHexRow[] src, FS.FilePath dst)
        {
            var count = src.Length;
            if(count != 0)
            {
                using var writer = dst.Writer();
                writer.WriteLine(Table.header53<ApiHexField>());

                ref readonly var row = ref first(src);
                for(var i=0; i<src.Length; i++)
                    writer.WriteLine(skip(row,i).DelimitedText());
            }
            return dst;
        }

        [Op]
        static ParseResult<ApiHexRow> row(string src)
        {
            try
            {
                var fields = src.SplitClean(FieldDelimiter);
                if(fields.Length !=  (uint)ApiHexRow.FieldCount)
                    return ParseResult.Fail<ApiHexRow>(src,"No data");

                var dst = new ApiHexRow();
                var index = 0;
                dst.Seq = NumericParser.succeed<int>(fields[index++]);
                dst.SourceSeq = NumericParser.succeed<int>(fields[index++]);
                dst.Address = MemoryAddressParser.succeed(fields[index++]);
                dst.Length = NumericParser.succeed<int>(fields[index++]);
                dst.TermCode = Enums.parse(fields[index++], ExtractTermCode.None);
                dst.Uri = ApiUriParser.Service.Parse(fields[index++]).Require();
                dst.ApiSig = CliSig.Parse(fields[index++]);
                dst.Data = new CodeBlock(dst.Address, Parsers.hex(true).ParseData(fields[index++], sys.empty<byte>()));
                return ParseResult.Success(src, dst);
            }
            catch(Exception e)
            {
                return ParseResult.Fail<ApiHexRow>(src, e);
            }
        }
    }
}