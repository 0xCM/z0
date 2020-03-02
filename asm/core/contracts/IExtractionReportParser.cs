//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public interface IExtractionReportParser : IAsmService
    {
        ParsedEncodingReport Parse(ApiHost src, ExtractionReport encoded);        
    }
}