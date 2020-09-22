//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using F = ApiExtractField;
    using R = ApiExtractBlock;

    using Report = ApiExtractReport;

    public class ApiExtractReport : Report<Report,F,R>
    {
        /// <summary>
        /// Loads a saved extract report
        /// </summary>
        /// <param name="src">The report path</param>
        public static ApiExtractReport Load(FilePath src)
        {
            var lines = src.ReadLines().Skip(1). Select(R.Parse).ToArray();
            if(lines.Length != 0)
                return new ApiExtractReport(lines[0].Uri.Host, lines);
            else
                return Empty;
        }

        public ApiHostUri ApiHost {get;}

        public override string ReportName
            => $"Extract report for {ApiHost.Format()}";

        public static Report Create(ApiHostUri host, ApiMemberExtract[] src)
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
                    OpSig : op.Member.Method.Signature().Format(),
                    Data : op.Encoded
                    );
            }

            return new Report(host, records);
        }

        public ApiExtractReport(){}

        internal ApiExtractReport(ApiHostUri host, R[] records)
            : base(records)
        {
            ApiHost = host;
        }
    }
}