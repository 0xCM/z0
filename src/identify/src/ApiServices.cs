//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using API = Z0;

    public readonly struct ApiServices
    {
        public static ParseReportParser ParseReportParser 
            => API.ParseReportParser.Service;

        public static IApiReflected ApiReflected 
            => new ApiReflected();

        public static IUriHexQuery UriHexQuery 
            => new UriHexQuery();       
    }
}