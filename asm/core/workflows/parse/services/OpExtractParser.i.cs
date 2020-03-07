//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public interface IOpExtractParser : IAsmService
    {
        MemberParseReport Parse(ApiHost src, MemberExtractReport encoded);        

        ParsedExtract[] Parse(params MemberExtract[] src);
    }
}