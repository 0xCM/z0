//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IParseReportParser
    {
        ParseResult<MemberParseReport> Parse(FilePath src);
    }

    public interface IReportParser<T>
        where T : ITabular
    {
        ParseResult<T[]> ParseRecords(FilePath src);
    }
}