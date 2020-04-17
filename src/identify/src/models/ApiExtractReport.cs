//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    
    using static Seed;

    using F = ApiExtractField;
    using R = ApiExtractRecord;
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
                return new ApiExtractReport(lines[0].Uri.HostPath, lines);
            else
                return Empty;
        }        

        public ApiHostUri ApiHost {get;}

        public override string ReportName => $"Extract report for {ApiHost.Format()}";

        public static Report Create(ApiHostUri host, ApiMemberExtract[] extracts)
        {
            var records = new ApiExtractRecord[extracts.Length];
            for(var i=0; i< extracts.Length; i++)
            {
                var op = extracts[i];
                records[i] = new ApiExtractRecord(                
                    Sequence : i,
                    Address : op.Member.Address,
                    Length : op.EncodedData.Length,
                    Uri : op.Uri,
                    OpSig : op.Member.Method.Signature().Format(),
                    Data : op.EncodedData
                    );

            }

            return new Report(host, records);
        }
        
        public ApiExtractReport(){}

        ApiExtractReport(ApiHostUri host, R[] records)
            : base(records)
        {
            this.ApiHost = host;
        }            
    }     
}