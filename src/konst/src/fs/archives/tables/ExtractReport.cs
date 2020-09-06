//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using F = ExtractField;
    using R = ExtractRecord;

    using Report = ExtractReport;

    public class ExtractReport : Report<Report,F,R>
    {
        /// <summary>
        /// Loads a saved extract report
        /// </summary>
        /// <param name="src">The report path</param>
        public static ExtractReport Load(FilePath src)
        {
            var lines = src.ReadLines().Skip(1). Select(R.Parse).ToArray();
            if(lines.Length != 0)
                return new ExtractReport(lines[0].Uri.Host, lines);
            else
                return Empty;
        }

        public ApiHostUri ApiHost {get;}

        public override string ReportName
            => $"Extract report for {ApiHost.Format()}";

        public static Report Create(ApiHostUri host, X86ApiExtract[] src)
        {
            var count = src.Length;
            var records = new ExtractRecord[count];
            for(var i=0; i< count; i++)
            {
                var op = src[i];
                records[i] = new ExtractRecord(
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

        public ExtractReport(){}

        internal ExtractReport(ApiHostUri host, R[] records)
            : base(records)
        {
            ApiHost = host;
        }
    }
}