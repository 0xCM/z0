//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public interface IOpExtractParser : IAsmService
    {
        ParsedOpReport Parse(ApiHost src, OpExtractReport encoded);        

        ParsedExtract[] Parse(OpExtract[] src);
    }
}