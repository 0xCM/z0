//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    /// <summary>
    /// Characterizes a service that extracts encoded data from a given base address
    /// </summary>
    public interface IMemoryExtractor : IService
    {
        Option<MemoryExtract> Extract(MemoryAddress src);        
    }    
}