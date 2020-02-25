//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    public interface IByteReader : IAppService
    {
        int Read(MemoryAddress src, int count, Span<byte> dst);

        int Read(MemoryAddress src, int count, ref byte dst);        
    }
}