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

    public readonly struct ParseReportParser
    {
        public static ParseResult<MemberParseReport> Parse(FilePath src)
        {
            var result = MemberParseRecord.load(src);
            if(result.Succeeded && (result.Value.Length != 0))
            {
                var records = result.Value;
                return ParseResult.Success(src.Name, MemberParseReport.create(records[0].Uri.Host, records));
            }
            else
            {
                if(result.Succeeded)
                    return ParseResult.Success(src.Name, MemberParseReport.Empty);
                else
                    return ParseResult.Fail<MemberParseReport>(src.Name);
            }
        }
    }
}