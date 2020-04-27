//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public interface IMemoryExtractParser : IService
    {
        Option<LocatedCode> Parse(LocatedCode src);        
    }
}