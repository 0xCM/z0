//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static Konst;

    using F = ApiExtractField;

    public struct ApiExtractReport
    {
        /// <summary>
        /// Loads a saved extract report
        /// </summary>
        /// <param name="src">The report path</param>
        public static ApiExtractReport Load(FilePath src)
        {
            var lines = src.ReadLines().Skip(1). Select(ParseBlock).ToArray();
            if(lines.Length != 0)
                return new ApiExtractReport(lines[0].Uri.Host, lines);
            else
                return default;
        }

        const int FieldCount = 6;

        public static ApiExtractBlock EmptyBlock
            => new ApiExtractBlock(0, MemoryAddress.Empty, 0, OpUri.Empty, EmptyString, CodeBlock.Empty);

        public static ApiExtractBlock ParseBlock(string src)
        {
            var fields = src.SplitClean(FieldDelimiter);
            if(fields.Length != FieldCount)
                return EmptyBlock;

            var parser = NumericParser.create<int>();
            var seq = parser.Parse(fields[0]).ValueOrDefault();
            var address = z.address(HexParsers.scalar().Parse(fields[1]).ValueOrDefault());
            var len = parser.Parse(fields[2]).ValueOrDefault();
            var uri = ApiUri.parse(fields[3]).ValueOrDefault(OpUri.Empty);
            var sig = fields[4];
            var data = fields[5].SplitClean(HexFormatSpecs.DataDelimiter).Select(HexParsers.bytes().Succeed).ToArray();
            var extract = new CodeBlock(address, data);
            return new ApiExtractBlock(seq, address, len, uri, sig, extract);
        }

        public ApiHostUri ApiHost {get;}

        public Index<ApiExtractBlock> Records {get;}

        public string ReportName
            => $"Extract report for {ApiHost.Format()}";

        public static string format(in ApiExtractBlock src, char delimiter)
        {
            var dst = Table.formatter<F>(delimiter);
            dst.Delimit(F.Sequence, src.Sequence);
            dst.Delimit(F.Address, src.Address);
            dst.Delimit(F.Length, src.Length);
            dst.Delimit(F.Uri, src.Uri);
            dst.Delimit(F.OpSig, src.OpSig);
            dst.Delimit(F.Data, src.Data);
            return dst.Format();
        }

        public static ApiExtractReport Create(ApiHostUri host, ApiMemberExtract[] src)
        {
            var count = src.Length;
            var records = new ApiExtractBlock[count];
            for(var i=0; i< count; i++)
            {
                var op = src[i];
                records[i] = new ApiExtractBlock(
                    Sequence : i,
                    Address : op.Member.Address,
                    Length : op.Encoded.Length,
                    Uri : op.OpUri,
                    OpSig : op.Member.Method.Metadata().Format(),
                    Data : op.Encoded
                    );
            }

            return new ApiExtractReport(host, records);
        }

        internal ApiExtractReport(ApiHostUri host, ApiExtractBlock[] records)
        {
            ApiHost = host;
            Records = records;
        }
    }
}