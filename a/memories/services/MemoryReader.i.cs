//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    /// <summary>
    /// Characterizes a service reads data from a source address and deposits to caller-supplied targets
    /// </summary>
    public interface IMemoryReader : IService
    {
        int Read(MemoryAddress src, int count, Span<byte> dst);

        int Read(MemoryAddress src, int count, ref byte dst);        
    }
}