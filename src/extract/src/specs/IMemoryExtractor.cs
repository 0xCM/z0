//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes a service that extracts encoded data from a given base address
    /// </summary>
    public interface IMemoryExtractor : IService
    {
        Option<Addressable> Extract(MemoryAddress src);        
    }    
}