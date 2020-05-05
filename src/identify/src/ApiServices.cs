//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct ApiServices
    {
        public static IParseReportParser ParseReportParser 
            => new ParseReportParser();

        public static IApiReflected ApiReflected 
            => new ApiReflected();

        public static IUriHexQuery UriHexQuery 
            => new UriHexQuery();       
    }
}