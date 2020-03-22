//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public interface IMemoryCapture : IAsmService
    {
        Option<MemoryExtract> Extract(MemoryAddress src);        

        Option<MemoryExtract> Parse(MemoryExtract src);

        Option<AsmInstructionList> Decode(MemoryExtract src);
                        
        Option<CapturedMemory> Capture(MemoryAddress src);        

    }
}