//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct ParseReportParser : IParseReportParser, IReportParser<MemberParseRecord>
    {
        public static ParseReportParser Service => default;

        public ParseResult<MemberParseReport> Parse(FilePath src)
        {
            var result = ParseRecords(src);
            if(result.Succeeded && (result.Value.Length != 0))
            {
                var records = result.Value;        
                var host = records[0].Uri.Host;
                var report = MemberParseReport.Create(host, records);
                return ParseResult.Success(src.Name, report);
            }
            else
            {
                if(result.Succeeded)
                    return ParseResult.Success(src.Name, MemberParseReport.Empty);
                else
                    return ParseResult.Fail<MemberParseReport>(src.Name);
            }
        }

        public ParseResult<MemberParseRecord[]> ParseRecords(FilePath src)
        {
            var attempts = src.ReadLines().Skip(1).Select(MemberParseRecord.Parse);
            var failed = attempts.Where(r => !r.Succeeded);
            var success = attempts.Where(r => r.Succeeded).Select(r => r.Value);
            if(failed.Length != 0 && success.Length == 0)
                return ParseResult.Fail<MemberParseRecord[]>(src.Name, failed[0].Reason);            
            else
                return ParseResult.Success(src.Name, success);
        }
    }    
}