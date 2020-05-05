//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
   
    using static Seed;
    using static Memories;

    public readonly struct ParseReportParser : IParseReportParser
    {
        public static IParseReportParser Service => default(ParseReportParser);

        public ParseResult<MemberParseReport> Parse(FilePath src)
            => MemberParseReport.Load(src);
    }    
}