//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Z0.Asm;

    public interface IMemoryCapture : IAsmService
    {
        Option<CapturedMemory> Capture(MemoryAddress src);        
    }
}