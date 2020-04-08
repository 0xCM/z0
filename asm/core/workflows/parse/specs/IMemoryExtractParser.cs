//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    
    public interface IMemoryExtractParser : IService
    {
        Option<MemoryExtract> Parse(MemoryExtract src);        
    }
}