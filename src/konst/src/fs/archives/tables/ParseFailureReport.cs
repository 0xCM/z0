//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    
    using F = ParseFailureField;
    using R = ParseFailureRecord;
    using Report = ParseFailureReport;

    public class ParseFailureReport : Report<Report,F,R>
    {        
        /// <summary>
        /// Loads a saved failure report
        /// </summary>
        /// <param name="src">The report path</param>
        public static ParseFailureReport Load(FilePath src)
        {
            var lines = src.ReadLines().Skip(1). Select(R.Parse).ToArray();
            if(lines.Length != 0)
                return new ParseFailureReport(lines[0].Uri.Host, lines);
            else
                return Empty;
        }        

        public ApiHostUri ApiHost {get;}

        public override string ReportName 
            => $"ParseFailure report for {ApiHost.Format()}";

        public static Report Create(ApiHostUri host, ExtractParseFailure[] failures)
        {
            var records = new ParseFailureRecord[failures.Length];
            for(var i=0; i< failures.Length; i++)
            {
                var failure = failures[i];
                records[i] = new ParseFailureRecord(                
                    Sequence : failure.Sequence,
                    Address : failure.Data.Address,
                    Length : failure.Data.Encoded.Length,
                    TermCode: failure.TermCode,
                    Uri : failure.OpUri,
                    Data : failure.Data.Encoded
                    );
            }

            return new Report(host, records);
        }
        
        public ParseFailureReport(){}

        ParseFailureReport(ApiHostUri host, R[] records)
            : base(records)
        {
            this.ApiHost = host;
        }            
    }     
}