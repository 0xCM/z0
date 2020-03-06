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
        Option<MemoryExtract> Extract(MemoryAddress src);        

        Option<MemoryExtract> Parse(MemoryExtract src);

        Option<AsmInstructionList> Decode(MemoryExtract src);
                        
        Option<CapturedMemory> Capture(MemoryAddress src);        

    }
}