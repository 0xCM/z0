//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    /// <summary>
    /// Characterizes a service reads data from a source address and deposits to caller-supplied targets
    /// </summary>
    public interface IMemoryReader : IService
    {
        int Read(MemoryAddress src, Span<byte> dst, int? count = null);

        int Read(MemoryAddress src, ref byte dst, int count);        
    }
}