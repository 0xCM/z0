//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Seed;

    using F = MemberParseField;
    using R = MemberParseRecord;
    using Report = MemberParseReport;

    public class MemberParseReport : Report<Report,F,R>
    {             
        /// <summary>
        /// Loads a saved report
        /// </summary>
        /// <param name="src">The report path</param>
        public static ParseResult<MemberParseReport> Load(FilePath src)
        {
            var attempts = src.ReadLines().Skip(1).Select(MemberParseRecord.Parse);
            var failed = attempts.Where(r => !r.Succeeded);
            var success = attempts.Where(r => r.Succeeded).Select(r => r.Value);
            if(failed.Length != 0 && success.Length == 0)
                return ParseResult.Fail<MemberParseReport>(src.Name, failed[0].Reason);            

            if(failed.Length != 0)
                term.warn($"Not all records from {src} parsed successfully");

            var host = success[0].Uri.HostPath;
            var report = MemberParseReport.Create(host,success);
            return ParseResult.Success(src.Name, report);
        }
        
        public ApiHostUri ApiHost {get;}

        [MethodImpl(Inline)]
        public static Report Create(ApiHostUri host, params R[] records)
            => new Report(records);

        public static Report Create(ApiHostUri host, ParsedMember[] extracts)
        {
            var records = new MemberParseRecord[extracts.Length];
            for(var i=0; i< records.Length; i++)
            {
                ref readonly var extract = ref extracts[i];
                records[i] = R.From(extract, i);
                
            }
            return new Report(records);
        }

        public MemberParseReport(){}
        
        [MethodImpl(Inline)]
        MemberParseReport(params R[] records)
            : base(records)
        {

        }
    }    
}