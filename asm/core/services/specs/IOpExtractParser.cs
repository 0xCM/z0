//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    
    public interface IOpExtractParser : IService
    {
        MemberParseReport Parse(IApiHost src, MemberExtractReport encoded);        

        ParsedExtract[] Parse(MemberExtract[] src);
    }
}